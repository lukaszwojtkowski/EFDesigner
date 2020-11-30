//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v3.0.0.5
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
   /// <summary>
   /// x
   /// </summary>
   public partial class UParentOptional: global::Testing.HiddenEntity, INotifyPropertyChanged
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected UParentOptional(): base()
      {
         PropertyInChild = "hello";
         UChildCollection = new System.Collections.Generic.HashSet<global::Testing.UChild>();
         UChildOptional = global::Testing.UChild.CreateUChildUnsafe();
         UChildRequired = global::Testing.UChild.CreateUChildUnsafe();

         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static UParentOptional CreateUParentOptionalUnsafe()
      {
         return new UParentOptional();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="uchildrequired"></param>
      public UParentOptional(global::Testing.UChild uchildrequired)
      {
         this.PropertyInChild = "hello";
         if (uchildrequired == null) throw new ArgumentNullException(nameof(uchildrequired));
         this.UChildRequired = uchildrequired;

         this.UChildCollection = new System.Collections.Generic.HashSet<global::Testing.UChild>();

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="uchildrequired"></param>
      public static UParentOptional Create(global::Testing.UChild uchildrequired)
      {
         return new UParentOptional(uchildrequired);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Backing field for PropertyInChild
      /// </summary>
      protected string _propertyInChild;
      /// <summary>
      /// When provided in a partial class, allows value of PropertyInChild to be changed before setting.
      /// </summary>
      partial void SetPropertyInChild(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of PropertyInChild to be changed before returning.
      /// </summary>
      partial void GetPropertyInChild(ref string result);

      /// <summary>
      /// Default value = &quot;hello&quot;
      /// </summary>
      public string PropertyInChild
      {
         get
         {
            string value = _propertyInChild;
            GetPropertyInChild(ref value);
            return (_propertyInChild = value);
         }
         set
         {
            string oldValue = _propertyInChild;
            SetPropertyInChild(oldValue, ref value);
            if (oldValue != value)
            {
               _propertyInChild = value;
            }
         }
      }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      protected global::Testing.UChild _uChildOptional;
      partial void SetUChildOptional(global::Testing.UChild oldValue, ref global::Testing.UChild newValue);
      partial void GetUChildOptional(ref global::Testing.UChild result);

      /// <summary>
      /// x
      /// </summary>
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

      protected ICollection<global::Testing.UChild> _uChildCollection;
      /// <summary>
      /// h
      /// </summary>
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

      protected global::Testing.UChild _uChildRequired;
      partial void SetUChildRequired(global::Testing.UChild oldValue, ref global::Testing.UChild newValue);
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

      public virtual event PropertyChangedEventHandler PropertyChanged;

      protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
      {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }

   }
}

