﻿  
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v4.2.6.3
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

namespace Transient
{
   public partial class Master
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public Master()
      {
         PersistentDetails = new System.Collections.Generic.HashSet<global::Transient.PersistentDetail>();
         TransientDetails = new System.Collections.Generic.HashSet<global::Transient.TransientDetail>();

         Init();
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Max length = 100
      /// </summary>
      [MaxLength(100)]
      [StringLength(100)]
      public string Foo { get; set; }

      /// <summary>
      /// Identity, Indexed, Required
      /// Unique identifier
      /// </summary>
      [Key]
      [Required]
      [System.ComponentModel.Description("Unique identifier")]
      public long Id { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      public virtual ICollection<global::Transient.PersistentDetail> PersistentDetails { get; private set; }

      public virtual global::Transient.TransientDetailAsJson TransientDetailAsJson { get; set; }

      public virtual ICollection<global::Transient.TransientDetail> TransientDetails { get; private set; }

   }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Transient
{
   public partial class PersistentDetail
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public PersistentDetail()
      {
         Init();
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Max length = 100
      /// </summary>
      [MaxLength(100)]
      [StringLength(100)]
      public string Bar { get; set; }

      /// <summary>
      /// Identity, Indexed, Required
      /// Unique identifier
      /// </summary>
      [Key]
      [Required]
      [System.ComponentModel.Description("Unique identifier")]
      public long Id { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

   }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Transient
{
   public partial class TransientDetail
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public TransientDetail()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_master0"></param>
      public TransientDetail(global::Transient.Master _master0)
      {
         if (_master0 == null) throw new ArgumentNullException(nameof(_master0));
         _master0.TransientDetails.Add(this);

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_master0"></param>
      public static TransientDetail Create(global::Transient.Master _master0)
      {
         return new TransientDetail(_master0);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Backing field for Baz
      /// </summary>
      protected string _baz;
      /// <summary>
      /// When provided in a partial class, allows value of Baz to be changed before setting.
      /// </summary>
      partial void SetBaz(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Baz to be changed before returning.
      /// </summary>
      partial void GetBaz(ref string result);

      public string Baz
      {
         get
         {
            string value = _baz;
            GetBaz(ref value);
            return (_baz = value);
         }
         set
         {
            string oldValue = Baz;
            SetBaz(oldValue, ref value);
            if (oldValue != value)
            {
               _baz = value;
            }
         }
      }

      /// <summary>
      /// Identity, Indexed, Required
      /// Unique identifier
      /// </summary>
      [Key]
      [Required]
      [System.ComponentModel.Description("Unique identifier")]
      public long Id { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

   }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Transient
{
   public partial class TransientDetailAsJson
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public TransientDetailAsJson()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_master0"></param>
      public TransientDetailAsJson(global::Transient.Master _master0)
      {
         if (_master0 == null) throw new ArgumentNullException(nameof(_master0));
         _master0.TransientDetailAsJson = this;

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_master0"></param>
      public static TransientDetailAsJson Create(global::Transient.Master _master0)
      {
         return new TransientDetailAsJson(_master0);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Identity, Indexed, Required
      /// Unique identifier
      /// </summary>
      [Key]
      [Required]
      [System.ComponentModel.Description("Unique identifier")]
      public long Id { get; set; }

      public string Zoom { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

   }
}
