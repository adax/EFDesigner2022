//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v4.2.6.1
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

namespace Sandbox_EFCore_Test
{
   public partial class Embedded
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public Embedded()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="id">Unique identifier</param>
      /// <param name="_entity10"></param>
      public Embedded(long id, global::Sandbox_EFCore_Test.Entity1 _entity10)
      {
         this.Id = id;

         if (_entity10 == null) throw new ArgumentNullException(nameof(_entity10));
         _entity10.Embedded = this;

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="id">Unique identifier</param>
      /// <param name="_entity10"></param>
      public static Embedded Create(long id, global::Sandbox_EFCore_Test.Entity1 _entity10)
      {
         return new Embedded(id, _entity10);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Indexed, Required
      /// Unique identifier
      /// </summary>
      [NotMapped]
      [System.ComponentModel.Description("Unique identifier")]
      public long Id { get; set; }

      [NotMapped]
      public string Property1 { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      public virtual global::Sandbox_EFCore_Test.Embedded2 Embedded2 { get; set; }

   }
}
