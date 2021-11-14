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

namespace Testing
{
   public partial class UParentRequired
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public UParentRequired()
      {
         UChildCollection = new System.Collections.Generic.HashSet<global::Testing.UChild>();

         Init();
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

      /// <summary>
      /// Backing field for UChildRequired
      /// </summary>
      protected global::Testing.UChild _uChildRequired;

      /// <summary>
      /// When provided in a partial class, allows value of UChildRequired to be changed before setting.
      /// </summary>
      partial void SetUChildRequired(global::Testing.UChild oldValue, ref global::Testing.UChild newValue);

      /// <summary>
      /// When provided in a partial class, allows value of UChildRequired to be changed before returning.
      /// </summary>
      partial void GetUChildRequired(ref global::Testing.UChild result);

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Testing.UChild UChildRequired
      {
         get
         {
            global::Testing.UChild value = _uChildRequired;
            GetUChildRequired(ref value);
            return (_uChildRequired = value);
         }
         set
         {
            global::Testing.UChild oldValue = _uChildRequired;
            SetUChildRequired(oldValue, ref value);
            if (oldValue != value)
            {
               _uChildRequired = value;
            }
         }
      }

      /// <summary>
      /// Backing field for UChildCollection
      /// </summary>
      protected ICollection<global::Testing.UChild> _uChildCollection;

      public virtual ICollection<global::Testing.UChild> UChildCollection
      {
         get
         {
            return _uChildCollection;
         }
         private set
         {
            _uChildCollection = value;
         }
      }

      /// <summary>
      /// Backing field for UChildOptional
      /// </summary>
      protected global::Testing.UChild _uChildOptional;

      /// <summary>
      /// When provided in a partial class, allows value of UChildOptional to be changed before setting.
      /// </summary>
      partial void SetUChildOptional(global::Testing.UChild oldValue, ref global::Testing.UChild newValue);

      /// <summary>
      /// When provided in a partial class, allows value of UChildOptional to be changed before returning.
      /// </summary>
      partial void GetUChildOptional(ref global::Testing.UChild result);

      public virtual global::Testing.UChild UChildOptional
      {
         get
         {
            global::Testing.UChild value = _uChildOptional;
            GetUChildOptional(ref value);
            return (_uChildOptional = value);
         }
         set
         {
            global::Testing.UChild oldValue = _uChildOptional;
            SetUChildOptional(oldValue, ref value);
            if (oldValue != value)
            {
               _uChildOptional = value;
            }
         }
      }

   }
}

