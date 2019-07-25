using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApp.CustomAttributes
{
    public class CustomAttributes
    {

    }

    public class LastNameNotDavis : ValidationAttribute, IClientValidatable
    {
        public string LastName { get; set; }

        public LastNameNotDavis()
        {
            this.LastName = LastName;
        }

        public override bool IsValid(object value)
        {
            var strValue = value as string;
            if (String.IsNullOrWhiteSpace(strValue))
                return true;
            return strValue.ToLower() != "davis";
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRule
            {
                ErrorMessage = this.ErrorMessage,
                ValidationType = "lastnamenotdavis"
            };
        }
    }

    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class DateBeforeMay2017Only : ValidationAttribute
    {
        public DateTime Date { get; set; }
        public DateBeforeMay2017Only()
        {
            this.Date = Date;
        }

        public override bool IsValid(object value)
        {
            var dateValue = value as DateTime?;
            if (dateValue == null)
            {
                return true;
            }
            var date = new DateTime(2017, 5, 1); // May 2017
            return dateValue.Value < date;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRule
            {
                ErrorMessage = this.ErrorMessage,
                ValidationType = "datebeforemay2017only"
            };
        }
    }

    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class FromDateAfterToDate : ValidationAttribute
    {

    }
}