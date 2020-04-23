using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFast
{
    class Customer
    {
        //고객 Data
        public int Num { get; set; }                //고객번호
        public string Name { get; set; }            //고객이름
        public string Address { get; set; }         //주소
        public string DetailAddress { get; set; }   //상세주소
        public string Address2 { get; set; }        //주소2
        public string DetailAddress2 { get; set; }  //상세주소2
        public string PhoneNumber { get; set; }     //전화번호1
        public string PhoneNumber2 { get; set; }    //전화번호2
        public string PhoneNumber3 { get; set; }    //전화번호3
        public DateTime Date { get; set; }            //고객등록일
    }
}
