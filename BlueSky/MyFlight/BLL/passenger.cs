using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
    public class passenger
    {
        public DataRow dr;
        private int kodorder;
        private string firstname;
        private string lastname;
        private string id;
        private string dataofbirth;
        private int numpassport;
        private string numphone;
        private string gmail;
        private string country;
        private string city;
        private string address;
        private int numhome;
        private int postalcode;

        private int placeF;
        private int chargercode;

        public string Firstname {
            get => firstname;
            set
            {
                if (!Validation.IsHebrew(value))
                    throw new Exception("הקש בעברית בלבד");
                firstname = value;
            }
        }
        public string Lastname { get => lastname; set
            {
                if (!Validation.IsHebrew(value))
                    throw new Exception("הקש בעברית בלבד");
                lastname = value;
            }
        }
        public int Kodorder { get => kodorder; set => kodorder = value; }
        public string Id { get => id; set
            {
                if (!Validation.CheckId(value))
                    throw new Exception("הקש ת.ז. תקינה");
                id = value;
            }
        }
        public string Dataofbirth { get => dataofbirth; set => dataofbirth = value; }
        public int Numpassport
        {
            get => numpassport; set
            {
                if (!Validation.IsNum(value.ToString()))
                    throw new Exception("הקש ספרות בלבד");
                numpassport = value;
            }
        }
        public string Numphone {
            get => numphone; set
            {
                if ((!Validation.IsPelepon(value.ToString()) && (!Validation.IsPelepon(value.ToString()))))
                    throw new Exception("הקש מספר טלפון תקין");
                numphone = value;
            }
        }
        public string Gmail 
            { get => gmail; set
                    {
                    if (!Validation.IsMail(value))
                        throw new Exception("הקש כתובת מייל תקינה");
                             gmail = value;
                }
}
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Address 
        {
            get => address; set
            {
                if (!Validation.IsHebrew(value) )
                    throw new Exception("הקש בעברית בלבד");
                address = value;
            }
        }
        public int Numhome
        {
            get => numhome; set
            {
                if (!Validation.IsNum(value.ToString()))
                    throw new Exception("הקש ספרות בלבד");
                numhome = value;
            }
        }
        public int Postalcode
        {
            get => postalcode; set
            {
                if (!Validation.IsNum(value.ToString()))
                    throw new Exception("הקש ספרות בלבד");
                postalcode = value;
            }
        }
      
        public int PlaceF { get => placeF; set => placeF = value; }
        public int Chargercode { get => this.chargercode; set => this.chargercode = value; }

        public passenger() { }

        public passenger(DataRow dr)
        {
            this.dr = dr;
            kodorder = Convert.ToInt32(dr["KodOrder"]);
            firstname = dr["Firstname"].ToString();
            lastname = dr["LastName"].ToString();
            id = (dr["ID"].ToString());
           dataofbirth= (dr["DateofBirth"].ToString());
           numpassport = Convert.ToInt32(dr["NumPassport"].ToString());
            numphone = (dr["PhonNumber"].ToString());
            gmail = dr["Gmail"].ToString();
           country = dr["Country"].ToString();
           city = dr["City"].ToString();
            address =dr["Address"].ToString();
            numhome= Convert.ToInt32(dr["NumHome"].ToString());
            postalcode = Convert.ToInt32(dr["PostalCode"].ToString());
            
            PlaceF = Convert.ToInt32(dr["PlaceF"]);
            //if(dr["chargekod"]!=null)
                chargercode = Convert.ToInt32(dr["chargekod"]);
        }

        public object GetPlaceF()
        {
            return placeF;
        }

        public void FillDataRow(object placeF)
        {
            
            dr["KodOrder"] =this. kodorder ;
            dr["Firstname"] = this.firstname;
            dr["LastName"] = lastname;
            dr["ID"] = id;
            dr["DateofBirth"] = dataofbirth;
            dr["NumPassport"] = numpassport;
            dr["PhonNumber"] = numphone;
            dr["Gmail"] = gmail;
            dr["Country"] = country;
            dr["City"] = city;
            dr["Address"] = address;
            dr["NumHome"] = numhome;
            dr["PostalCode"] = postalcode;
            dr["PlaceF"] = placeF;
            dr["chargekod"] = chargercode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
      
        public invetation ThisInvetation()
        {
            invetationDB tblc = new invetationDB();
            return tblc.Find(this.kodorder);
        }
        public  string myid()
        {
            return this.id;

        }
    }
}
