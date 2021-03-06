﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Text;

namespace CollectionTesting.Library
{
    public class StringCollection : GenericCollection<string>
    {
        //public StringCollection() : base(new List<string> { "a" })
        public StringCollection() : base() // calls zero-param ctor of parent.
        {
            // 1. constructors are not inherited.
            // 2. every child-class constructor has to call exactly one
            //    parent class constructor. (by default, it tries to call
            //    a zero-parameter constructor first.)
        }

        public StringCollection(IEnumerable<string> coll) : base(coll)
        {
        }

        public void Add(string s)
        {
            List.Add(s);
        }

        public void Remove(string s)
        {
            List.Remove(s);
        }

        public string GetLongestString()
        {
            if (List.Count == 0)
            {
                return null;
            }

            var maxLength = 0;
            string max = null;
            foreach (var item in List)
            {
                if (item?.Length > maxLength)
                {
                    maxLength = item.Length;
                    max = item;
                }
            }
            return max;
        }

        // we can override most any operator: +, -, +=, ||, &&, ==
        public string this[int index]
        {
            get => List[index];
            set { List[index] = value; }
        }

        public void RemoveShortest()
        {
            throw new NotImplementedException();
        }
    }
}