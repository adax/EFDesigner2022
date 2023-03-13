//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v4.2.3.2
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Credit.API.Domain_RE.Models_RE
{
   public partial class PublicRecords
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected PublicRecords()
      {
         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static PublicRecords CreatePublicRecordsUnsafe()
      {
         return new PublicRecords();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="publicrecordid"></param>
      /// <param name="creditprofileid">Foreign key for CreditProfiles.PublicRecords &lt;--&gt; PublicRecords.CreditProfile. </param>
      /// <param name="creditprofile"></param>
      public PublicRecords(Guid publicrecordid, Guid creditprofileid, global::Credit.API.Domain_RE.Models_RE.CreditProfiles creditprofile)
      {
         this.PublicRecordId = publicrecordid;

         this.CreditProfileId = creditprofileid;

         if (creditprofile == null) throw new ArgumentNullException(nameof(creditprofile));
         this.CreditProfile = creditprofile;
         creditprofile.PublicRecords.Add(this);

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="publicrecordid"></param>
      /// <param name="creditprofileid">Foreign key for CreditProfiles.PublicRecords &lt;--&gt; PublicRecords.CreditProfile. </param>
      /// <param name="creditprofile"></param>
      public static PublicRecords Create(Guid publicrecordid, Guid creditprofileid, global::Credit.API.Domain_RE.Models_RE.CreditProfiles creditprofile)
      {
         return new PublicRecords(publicrecordid, creditprofileid, creditprofile);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Max length = 3
      /// </summary>
      [MaxLength(3)]
      [StringLength(3)]
      public string AdjustmentPercent { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string Amount { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string BankruptcyVoluntaryIndicator { get; set; }

      /// <summary>
      /// Max length = 4
      /// </summary>
      [MaxLength(4)]
      [StringLength(4)]
      public string BookPageSequence { get; set; }

      /// <summary>
      /// Max length = 500
      /// </summary>
      [MaxLength(500)]
      [StringLength(500)]
      public string ConsumerComment { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string CourtCode { get; set; }

      /// <summary>
      /// Max length = 100
      /// </summary>
      [MaxLength(100)]
      [StringLength(100)]
      public string CourtName { get; set; }

      /// <summary>
      /// Indexed, Required
      /// Foreign key for CreditProfiles.PublicRecords &lt;--&gt; PublicRecords.CreditProfile. 
      /// </summary>
      [Required]
      [System.ComponentModel.Description("Foreign key for CreditProfiles.PublicRecords <--> PublicRecords.CreditProfile. ")]
      public Guid CreditProfileId { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string DisputeFlag { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string Ecoa { get; set; }

      /// <summary>
      /// Max length = 5
      /// </summary>
      [MaxLength(5)]
      [StringLength(5)]
      public string Evaluation { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string FilingDate { get; set; }

      /// <summary>
      /// Max length = 250
      /// </summary>
      [MaxLength(250)]
      [StringLength(250)]
      public string PlaintiffName { get; set; }

      /// <summary>
      /// Identity, Required
      /// </summary>
      [Key]
      [Required]
      public Guid PublicRecordId { get; set; }

      /// <summary>
      /// Max length = 30
      /// </summary>
      [MaxLength(30)]
      [StringLength(30)]
      public string ReferenceNumber { get; set; }

      /// <summary>
      /// Max length = 3
      /// </summary>
      [MaxLength(3)]
      [StringLength(3)]
      public string RepaymentPercent { get; set; }

      /// <summary>
      /// Max length = 100
      /// </summary>
      [MaxLength(100)]
      [StringLength(100)]
      public string Status { get; set; }

      /// <summary>
      /// Max length = 10
      /// </summary>
      [MaxLength(10)]
      [StringLength(10)]
      public string StatusDate { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Credit.API.Domain_RE.Models_RE.CreditProfiles CreditProfile { get; set; }

   }
}
