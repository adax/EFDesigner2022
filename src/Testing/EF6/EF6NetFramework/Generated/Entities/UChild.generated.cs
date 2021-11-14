//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v3.0.4.7
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
using System.Data.Entity.Spatial;

namespace Testing
{
   public partial class UChild
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected UChild()
      {
         // NOTE: This class has one-to-one associations with UChild.
         // One-to-one associations are not validated in constructors since this causes a scenario where each one must be constructed before the other.

         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static UChild CreateUChildUnsafe()
      {
         return new UChild();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_uparentrequired1"></param>
      /// <param name="_uparentrequired2"></param>
      public UChild(global::Testing.UParentRequired _uparentrequired1, global::Testing.UParentRequired _uparentrequired2)
      {
         // NOTE: This class has one-to-one associations with UChild.
         // One-to-one associations are not validated in constructors since this causes a scenario where each one must be constructed before the other.

         if (_uparentrequired1 == null) throw new ArgumentNullException(nameof(_uparentrequired1));
         _uparentrequired1.UChildCollection.Add(this);

         if (_uparentrequired2 == null) throw new ArgumentNullException(nameof(_uparentrequired2));
         _uparentrequired2.UChildOptional = this;

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_uparentrequired1"></param>
      /// <param name="_uparentrequired2"></param>
      public static UChild Create(global::Testing.UParentRequired _uparentrequired1, global::Testing.UParentRequired _uparentrequired2)
      {
         return new UChild(_uparentrequired1, _uparentrequired2);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Backing field for Id
      /// </summary>
      internal int _id;
      /// <summary>
      /// When provided in a partial class, allows value of Id to be changed before setting.
      /// </summary>
      partial void SetId(int oldValue, ref int newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Id to be changed before returning.
      /// </summary>
      partial void GetId(ref int result);

      /// <summary>
      /// Identity, Indexed, Required
      /// </summary>
      [Key]
      [Required]
      public int Id
      {
         get
         {
            int value = _id;
            GetId(ref value);
            return (_id = value);
         }
         set
         {
            int oldValue = _id;
            SetId(oldValue, ref value);
            if (oldValue != value)
            {
               _id = value;
            }
         }
      }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

   }
}

