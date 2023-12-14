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

namespace StoredProcs
{
   public partial class Grade
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public Grade()
      {
         Students = new System.Collections.Generic.HashSet<global::StoredProcs.Student>();

         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="name"></param>
      /// <param name="school"></param>
      public Grade(string name, global::StoredProcs.School school)
      {
         if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
         this.Name = name;

         if (school == null) throw new ArgumentNullException(nameof(school));
         this.School = school;
         school.Grades.Add(this);

         Students = new System.Collections.Generic.HashSet<global::StoredProcs.Student>();
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="name"></param>
      /// <param name="school"></param>
      public static Grade Create(string name, global::StoredProcs.School school)
      {
         return new Grade(name, school);
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

      /// <summary>
      /// Indexed, Required, Max length = 50
      /// </summary>
      [Required]
      [MaxLength(50)]
      [StringLength(50)]
      public string Name { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::StoredProcs.School School { get; set; }

      public virtual ICollection<global::StoredProcs.Student> Students { get; private set; }

   }
}
