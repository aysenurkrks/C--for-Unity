﻿using System;

namespace kurucuMetod{
	class Program {


			public static void Main (String [] args){

                    Calisan c1 = new Calisan();
                    c1.ad="aysenur";
                    c1.soyad="krks";
                    c1.no=4565321;
                    c1.departman="ik";

                    c1.calisanBilgileri();
                    Console.WriteLine("*************");
                    Calisan c2 =new Calisan();
                    c2.ad="mstf";
                    c2.soyad="grbz";
                    c2.no=65646;
                    c2.departman="arge";

                    c2.calisanBilgileri();
                    Console.WriteLine("*************");
                    Calisan c3 = new Calisan("deneme", "lorem", 5656, "deneme");
                    c3.calisanBilgileri();
                    Console.WriteLine("*************");
                    Calisan c4 = new Calisan("asd","soyad");
                    c4.calisanBilgileri();
				

		}

	}

    class Calisan{

        public string ad;
        public string soyad;
        public int  no;
        public string departman;

        public Calisan(string ad, string soyad, int no, string departman){
            this.ad=ad;
            this.soyad=soyad;
            this.departman=departman;
            this.no=no;


        }

        public Calisan(string ad, string soyad){
            this.ad=ad;
            this.soyad=soyad;


        }

        public Calisan(){}

        
        public void calisanBilgileri(){
            Console.WriteLine("Çalışan Adı : {0}", ad);
            Console.WriteLine("Çalışan soyadı : {0}", soyad);
            Console.WriteLine("Çalışan departman : {0}", departman);
            Console.WriteLine("Çalışan no : {0}", no);
        }

    }
}