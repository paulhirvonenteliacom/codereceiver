using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Code.Models
{
    public class PersonInformation
    {
        public int Id { get; set; }

        [Display(Name="Förnamn")]
        public string PFirstName { get; set; }

        [Display(Name = "Efternamn")]
        public string PLastName { get; set; }

        [Display(Name = "Gatuadress")]
        public string PStreetAddress { get; set; }

        [Display(Name = "Postnummer")]
        public string PPostalCode { get; set; }

        [Display(Name = "Ort")]
        public string PCity { get; set; }

        [Display(Name = "Personnummer")]
        public string PPersonalNumber { get; set; }

        [Display(Name = "Telefonnummer, hem")]
        public string PPhoneNumberHome { get; set; }

        [Display(Name = "Telefonnummer, arbete/skola")]
        public string PPhoneNumberWork { get; set; }

        [Display(Name = "Mobiltelefonnummer")]
        public string PPhoneNumberMobile { get; set; }

        [Display(Name = "E-post")]
        public string PEmail { get; set; }


        [Display(Name = "Förnamn")]
        public string SFirstName { get; set; }

        [Display(Name = "Efternamn")]
        public string SLastName { get; set; }

        [Display(Name = "Gatuadress")]
        public string SStreetAddress { get; set; }

        [Display(Name = "Postnummer")]
        public string SPostalCode { get; set; }

        [Display(Name = "Ort")]
        public string SCity { get; set; }

        [Display(Name = "Organisationsnummer")]
        public string SOrganisationNumber { get; set; }

        [Display(Name = "Telefonnummer")]
        public string SPhoneNumber { get; set; }

        [Display(Name = "E-post")]
        public string SEmail { get; set; }
    }
}