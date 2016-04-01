using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_String_Disperser
{
    using System;
    using System.Collections;

    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable
    {
        private string[] elements;

        public StringDisperser(params string[] elements)
        {
            this.Elements = elements;
        }

        public string[] Elements
        {
            get
            {
                string[] elementsCopy = new string[this.elements.Length];
                Array.Copy(this.elements, elementsCopy, this.elements.Length);

                return elementsCopy;
            }

            private set { this.elements = value; }
        }

        public static bool operator ==(StringDisperser stringDisperserLeft, StringDisperser stringDisperserRight)
        {
            return stringDisperserLeft.Equals(stringDisperserRight);
        }

        public static bool operator !=(StringDisperser stringDisperserLeft, StringDisperser stringDisperserRight)
        {
            return !stringDisperserLeft.Equals(stringDisperserRight);
        }

        public override bool Equals(object obj)
        {
            StringDisperser otherStringDisperser = (StringDisperser)obj;

            bool areEqual = this.ToString() == otherStringDisperser.ToString();

            return areEqual;
        }

        public override string ToString()
        {
            return string.Join(string.Empty, this.Elements);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public object Clone()
        {
            string[] copiedElements = new string[this.Elements.Length];
            Array.Copy(this.Elements, copiedElements, this.Elements.Length);

            return new StringDisperser(copiedElements);
        }

        public int CompareTo(StringDisperser otherStringDisperser)
        {
            return this.ToString().CompareTo(otherStringDisperser.ToString());
        }

        public IEnumerator GetEnumerator()
        {
            string disperserAsString = this.ToString();

            for (var i = 0; i < disperserAsString.Length; i++)
            {
                yield return disperserAsString[i];
            }
        }
    }
}
