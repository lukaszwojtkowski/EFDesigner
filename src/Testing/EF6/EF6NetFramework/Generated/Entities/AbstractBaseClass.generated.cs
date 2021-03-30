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
   public abstract partial class AbstractBaseClass: global::Testing.BaseClassWithRequiredProperties
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to being abstract.
      /// </summary>
      protected AbstractBaseClass(): base()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="property0"></param>
      protected AbstractBaseClass(string property0)
      {
         if (string.IsNullOrEmpty(property0)) throw new ArgumentNullException(nameof(property0));
         this.Property0 = property0;

         Init();
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

   }
}

