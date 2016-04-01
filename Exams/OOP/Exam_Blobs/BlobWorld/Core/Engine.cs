namespace BlobWorld.Core
{
    using System;
    using System.Linq;
    using System.Text;

    using Interfaces;
    using Models;
    using System.Collections.Generic;
    using Enums;

    public class Engine : IRunnable
    {
        private readonly IInputReader reader;
        private readonly IOutputWriter writer;
        private readonly Dictionary<string, Blob> data;
        private int turn = 0;
        private bool printDetailedInformation = false;
        private bool currentTurnBehaviorActivated = false;

        public Engine(
            IInputReader reader,
            IOutputWriter writer,
            Dictionary<string, Blob> data)
        {
            this.reader = reader;
            this.writer = writer;
            this.data = data;
        }

        public virtual void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split();

                this.ExecuteCommand(input);
            }
        }

        protected virtual void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    string[] rest = new string[inputParams.Length - 1];
                    Array.Copy(inputParams, 1, rest, 0, inputParams.Length - 1);
                    this.ExecuteCreateCommand(rest);
                    break;
                case "attack":
                    this.turn++;
                    this.ExecuteAttackCommand(inputParams[1], inputParams[2]);
                    break;
                case "pass":
                    this.turn++;
                    this.ExecutePassCommand();
                    break;
                case "status":
                    this.turn++;
                    this.ExecuteStatusCommand();
                    break;
                case "report-events":
                    if (this.turn == 0)
                        this.printDetailedInformation = true;
                    break;
                case "drop":
                    Environment.Exit(0);
                    break;
                default:
                    throw new ArgumentException("Unknown command.");
            }
        }

        private void ExecuteCreateCommand(string[] rest)
        {
            Behaviors behavior = Behaviors.Aggressive;
            behavior = (Behaviors)(Enum.Parse(typeof(Behaviors), rest[3]));
            Attacks attack = Attacks.PutridFart;
            attack = (Attacks)(Enum.Parse(typeof(Attacks), rest[4]));
            this.data.Add(rest[0], new Blob(rest[0], int.Parse(rest[1]), int.Parse(rest[2]), behavior, attack));
        }

        private void ExecuteAttackCommand(string first, string second)
        {
            if (data[first].State == State.KILLED)
            {
                throw new AccessViolationException("Dead Blobs can't attack!");
            }
            if (data[second].State == State.KILLED)
            {
                throw new AccessViolationException("Dead Blobs can't be attacked!");
            }
            DoAttack(data[first], data[second]);
            ClacBehaviorEffect(first);
            ClacBehaviorEffect(second);
        }

        private void goBehave(string blob)
        {
            switch (data[blob].Behavior)
            {
                case Behaviors.Aggressive:
                    if (this.printDetailedInformation)
                        Toggled(data[blob]);
                    data[blob].BehaviorState = BehaviorState.Activated;
                    data[blob].turn = this.turn;
                    data[blob].Damage = data[blob].Damage * 2;
                    break;
                case Behaviors.Inflated:
                    if (this.printDetailedInformation)
                        Toggled(data[blob]);
                    data[blob].BehaviorState = BehaviorState.Activated;
                    data[blob].turn = this.turn;
                    data[blob].Health = data[blob].Health + 50;
                    break;
            }
        }

        private void CalcAttackEffect(string first, string second)
        {
            int damageToBeMade = 0;
            switch (data[first].Attack)
            {
                case Attacks.PutridFart:
                    if (data[second].Health <= data[first].Damage)
                    {
                        if (data[second].Behavior == Behaviors.Inflated)
                            if
                                (data[second].BehaviorState == BehaviorState.notactivated)
                            {
                                data[second].Health = 0;
                                goBehave(second);
                            }
                            else
                            {
                                data[second].Health = 0;
                                if (this.printDetailedInformation)
                                {
                                    WasKilled(second);
                                }
                                data[second].State = State.KILLED;
                            }
                    }
                    else
                    {
                        data[second].Health = data[second].Health - data[first].Damage;
                        if (data[second].Health <= data[second].IntialHealth / 2)
                        {
                            if (data[second].BehaviorState == BehaviorState.notactivated)
                            {
                                goBehave(second);
                            }
                        }
                    }
                    break;
                case Attacks.Blobplode:

                    if (data[first].Health > 1)
                    {
                        data[first].Health = data[first].Health - data[first].Health / 2;
                        if ((data[first].Health <= data[first].IntialHealth / 2) && (data[first].BehaviorState == BehaviorState.notactivated))
                        {
                            goBehave(first);
                            damageToBeMade = data[first].Damage * 2;
                        }
                        else
                        {
                            damageToBeMade = data[first].Damage * 2;
                        }
                    }
                    else
                    {
                        if ((data[first].Health <= data[first].IntialHealth / 2) && (data[first].BehaviorState == BehaviorState.notactivated))
                        {
                            goBehave(first);
                            damageToBeMade = data[first].Damage * 2;
                        }
                        else
                        {
                            damageToBeMade = data[first].Damage * 2;
                        }
                    }

                    if (data[second].Health <= damageToBeMade)
                    {
                        if (data[second].Behavior == Behaviors.Inflated)
                            if (data[second].BehaviorState == BehaviorState.notactivated)
                            {
                                data[second].Health = 0;
                                goBehave(second);
                            }
                            else
                            {
                                data[second].Health = 0;
                                if (this.printDetailedInformation)
                                {
                                    WasKilled(second);
                                }
                                data[second].State = State.KILLED;
                            }
                    }
                    else
                    {
                        data[second].Health = data[second].Health - damageToBeMade;
                        if (data[second].Health <= data[second].IntialHealth / 2)
                        {
                            if (data[second].BehaviorState == BehaviorState.notactivated)
                            {
                                goBehave(second);
                            }
                        }
                    }
                    break;
            }
        }

        private void ClacBehaviorEffect(string blob)
        {
            switch (data[blob].Behavior)
            {
                case Behaviors.Aggressive:
                    if (data[blob].BehaviorState == BehaviorState.Activated)
                    {
                        if ((this.turn != data[blob].turn) && (this.turn > 0))
                        {
                            if (data[blob].Damage - 5 <= data[blob].IntialDamage)
                            {
                                data[blob].Damage = data[blob].IntialDamage;
                            }
                            else
                            {
                                data[blob].Damage = data[blob].Damage - 5;
                            }
                        }
                    }
                    else
                    {
                        if (data[blob].Health <= data[blob].IntialHealth / 2)
                        {
                            goBehave(blob);
                        }
                    }
                    break;
                case Behaviors.Inflated:
                    if (data[blob].BehaviorState == BehaviorState.Activated)
                    {
                        if ((this.turn != data[blob].turn) && (this.turn > 0))
                        {
                            if (data[blob].Health - 10 <= 0)
                            {
                                data[blob].Health = 0;
                                if (this.printDetailedInformation)
                                {
                                    WasKilled(blob);
                                }
                                data[blob].State = State.KILLED;
                            }
                            else
                            {
                                data[blob].Health = data[blob].Health - 10;
                            }
                        }
                    }
                    else
                    {
                        if (data[blob].Health <= data[blob].IntialHealth / 2)
                        {
                            goBehave(blob);
                        }
                    }
                    break;
            }
        }

        private void ExecuteStatusCommand()
        {
            StringBuilder output = new StringBuilder();
            foreach (KeyValuePair<string, Blob> entry in data)
            {
                if (entry.Value.State == State.KILLED)
                {
                    output.Append($"Blob {entry.Key} KILLED{Environment.NewLine}");
                }
                else
                {
                    output.Append(
                        $"Blob {entry.Key}: {entry.Value.Health} HP, {entry.Value.Damage} Damage{Environment.NewLine}");
                    ClacBehaviorEffect(entry.Key);
                }
            }
            this.writer.Print(output.ToString().Trim());
        }
        private void ExecutePassCommand()
        {
            StringBuilder output = new StringBuilder();
            foreach (KeyValuePair<string, Blob> entry in data)
            {
                ClacBehaviorEffect(entry.Key);
            }
        }

        private void WasKilled(string blob)
        {
            StringBuilder output = new StringBuilder();
            output.Append($"Blob {blob} was killed{Environment.NewLine}");
            this.writer.Print(output.ToString().Trim());
        }

        private void Toggled(Blob blob)
        {
            string behavior = "";
            StringBuilder output = new StringBuilder();
            if (blob.Behavior == Behaviors.Inflated)
            {
                behavior = "InflatedBehavior";
            }
            else
            {
                behavior = "AggressiveBehavior";
            }
            output.Append($"Blob {blob.Name} toggled {behavior}{Environment.NewLine}");
            this.writer.Print(output.ToString().Trim());
        }

        private void GoAgressive(Blob blob)
        {
            blob.Damage = blob.Damage;
            if (this.printDetailedInformation)
                Toggled(blob);
            blob.BehaviorState = BehaviorState.Activated;
        }
        private void GoInflated(Blob blob)
        {
            blob.Health = blob.Health + 50;
            if (this.printDetailedInformation)
                Toggled(blob);
            blob.BehaviorState = BehaviorState.Activated;
        }
        private void DoPutridFart(Blob blob1, Blob blob2)
        {
            if (blob2.Health <= blob1.Damage)
            {
                if ((blob2.Behavior == Behaviors.Inflated) && (blob2.BehaviorState == BehaviorState.notactivated))
                {
                    blob2.Health = 0;
                    goBehave(blob2.Name);
                }
                else
                {
                    blob2.Health = 0;
                    if (this.printDetailedInformation)
                    {
                        WasKilled(blob2.Name);
                    }
                    blob2.State = State.KILLED;
                }
            }
            else
            {
                blob2.Health = blob2.Health - blob1.Damage;
                if ((blob2.Health <= blob2.IntialHealth / 2) && (blob2.BehaviorState == BehaviorState.notactivated))
                {
                    goBehave(blob2.Name);
                }
            }
        }
        private void DoBlobplode(Blob blob1, Blob blob2)
        {
            int damageToBeMade = 0;
            if (blob1.Health > 1)
            {
                blob1.Health = blob1.Health - blob1.Health / 2;
                if ((blob1.Health <= blob1.IntialHealth / 2) && (blob1.BehaviorState == BehaviorState.notactivated))
                {
                    goBehave(blob1.Name);
                    damageToBeMade = blob1.Damage * 2;
                }
                else
                {
                    damageToBeMade = blob1.Damage * 2;
                }
            }
            else
            {
                if ((blob1.Health <= blob1.IntialHealth / 2) && (blob1.BehaviorState == BehaviorState.notactivated))
                {
                    goBehave(blob1.Name);
                    damageToBeMade = blob1.Damage * 2;
                }
                else
                {
                    damageToBeMade = blob1.Damage * 2;
                }
            }

            if (blob2.Health <= damageToBeMade)
            {
                if ((blob2.Behavior == Behaviors.Inflated) && (blob2.BehaviorState == BehaviorState.notactivated))
                {
                    blob2.Health = 0;
                    goBehave(blob2.Name);
                }
                else
                {
                    blob2.Health = 0;
                    if (this.printDetailedInformation)
                    {
                        WasKilled(blob2.Name);
                    }
                    blob2.State = State.KILLED;
                }
            }
            else
            {
                blob2.Health = blob2.Health - damageToBeMade;
                if ((blob2.Health <= blob2.IntialHealth / 2) && (blob2.BehaviorState == BehaviorState.notactivated))
                {
                    goBehave(blob2.Name);
                }
            }
        }
        private void DoAttack(Blob blob1, Blob blob2)
        {
            switch (blob1.Attack)
            {
                case Attacks.PutridFart:
                    DoPutridFart(blob1, blob2);
                    break;
                case Attacks.Blobplode:
                    DoBlobplode(blob1, blob2);
                    break;
            }
        }
    }
}
