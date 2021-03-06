﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CustomComponentKendo.Models
{
    public class BookingVm
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "ایمیل")] public string Email { get; set; }

        [Display(Name = "موبایل")] public string Mobile { get; set; }

        [Display(Name = "کد ملی")] public string NationalCode { get; set; }

        [Display(Name = "شماره کارت بانکی")] public string CardNumber { get; set; }

        [Display(Name = "تاریخ")]
        [UIHint("Date")]
        public DateTime Date { get; set; }

        [Display(Name = "ساعت")]
        [UIHint("Time")]
        public string Time { get; set; }


        [Display(Name = "تاریخ و ساعت")]
        [UIHint("DateTime")]
        public DateTime DateTime { get; set; }

        [Display(Name = "رمزعبور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "توضیحات")] public string Discription { get; set; }
        [Display(Name = "چک باکس ")] public bool IsVilcher { get; set; }
        [Display(Name = "خدمات حيوان خانگي ")] public bool IsHivanat { get; set; }

        [Display(Name = "شماره ")]
        [UIHint("Number")]
        public int FlightNmber { get; set; }

        [Display(Name = "مقصد")] public short? Destination { get; set; }

        [Display(Name = "جنسیت")] public short? Jensiat { get; set; }

        public long DataIdFinal { get; set; }
        public string SerialNumberPos { get; set; }
        public string LatinFirstName { get; set; }
        public string LatinLastName { get; set; }
        public string PNR { get; set; }
        public string WebSite { get; set; }

        [Display(Name = "شماره کارت بانکی")] public string CartNumber { get; set; }

        [Display(Name = "آپلود عکس")] public string ImageUrl { get; set; }

        [Display(Name = "توضیحات")]
        [AllowHtml]
        [UIHint("RichText")]
        public string DescriptionAllowHtml { get; set; }

        [Display(Name = "بارکد")]
        [UIHint("QRCode")]
        public string Qrcode { get; set; }
        [Display(Name = "اسلایدر")]
        [UIHint("Slider")]
        public double Slider { get; set; }


        //public static explicit operator Booking(BookingVm model)
        //{
        //    var obj = new Booking
        //    {
        //        Discription = model.Discription,
        //        Email = model.Email,
        //        Name = model.Name,
        //        LastName = model.LastName,
        //        Mobile = model.Mobile,
        //        NationalCode = model.NationalCode,
        //        Date = model.Date,
        //        Time = model.Time,
        //        AirLine = model.AirLine,
        //        Destination = model.Destination,
        //        Origin = model.Origin,
        //        FlightNmber = model.FlightNmber,
        //        Jensiat = model.Jensiat,
        //        Password = model.Password,
        //        IsHivanat = model.IsHivanat,
        //        IsVilcher = model.IsVilcher,
        //        Id = model.Id,
        //    };
        //    return obj;
        //}

        //public static explicit operator BookingVm(Booking model)
        //{
        //    var obj = new BookingVm
        //    {
        //        Discription = model.Discription,
        //        Email = model.Email,
        //        Name = model.Name,
        //        LastName = model.LastName,
        //        Mobile = model.Mobile,
        //        NationalCode = model.NationalCode,
        //        Date = model.Date ?? DateTime.Now,
        //        Time = model.Time ,
        //        AirLine = model.AirLine,
        //        Destination = model.Destination,
        //        Origin = model.Origin,
        //        FlightNmber = model.FlightNmber,
        //        Jensiat = model.Jensiat,
        //        Password = model.Password,
        //        IsHivanat = model.IsHivanat,
        //        IsVilcher = model.IsVilcher,
        //        Id = model.Id,
        //        CardNumber=model.Cards.FirstOrDefault()?.CardNumber

        //    };
        //    return obj;
        //}
    }
}