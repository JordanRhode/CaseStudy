﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaseStudy.Business
{
    public class Product
    {
        #region Properties
        private long? _productID = null;
        public long? ProductID
        {
            get { return _productID; }
        }

        private string _name = null;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description = null;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private long? _price = null;
        public long? Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public enum Types
        {
            Lesson,
            Book,
            Material,
            Equipment,
            Unknown
        }

        private Types _type = Types.Unknown;
        public Types Type
        {
            get { return _type; }
            set { _type = value; }
        }
        #endregion

        public override bool Equals(object obj)
        {
            if (obj is Product)
            {
                Product product = (Product)obj;
                return ((this.Name == product.Name) && (this.Description == product.Description) && (this.Type == product.Type));
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("Product: {0}, Description: {1}, Type: {2}", this.Name, this.Description, this.Type);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }        
    }
}
