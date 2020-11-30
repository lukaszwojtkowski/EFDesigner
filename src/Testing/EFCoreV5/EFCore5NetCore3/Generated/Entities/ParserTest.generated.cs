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
   public partial class ParserTest
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected ParserTest()
      {
         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static ParserTest CreateParserTestUnsafe()
      {
         return new ParserTest();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="foo"></param>
      public ParserTest(long foo)
      {
         this.foo = foo;


         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="foo"></param>
      public static ParserTest Create(long foo)
      {
         return new ParserTest(foo);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Backing field for Id
      /// </summary>
      protected int _id;
      /// <summary>
      /// When provided in a partial class, allows value of Id to be changed before setting.
      /// </summary>
      partial void SetId(int oldValue, ref int newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Id to be changed before returning.
      /// </summary>
      partial void GetId(ref int result);

      /// <summary>
      /// Identity, Required
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
         protected set
         {
            int oldValue = _id;
            SetId(oldValue, ref value);
            if (oldValue != value)
            {
               _id = value;
            }
         }
      }

      /// <summary>
      /// Backing field for foo
      /// </summary>
      protected long _foo;
      /// <summary>
      /// When provided in a partial class, allows value of foo to be changed before setting.
      /// </summary>
      partial void Setfoo(long oldValue, ref long newValue);
      /// <summary>
      /// When provided in a partial class, allows value of foo to be changed before returning.
      /// </summary>
      partial void Getfoo(ref long result);

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public long foo
      {
         get
         {
            long value = _foo;
            Getfoo(ref value);
            return (_foo = value);
         }
         set
         {
            long oldValue = _foo;
            Setfoo(oldValue, ref value);
            if (oldValue != value)
            {
               _foo = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name1
      /// </summary>
      protected string _name1;
      /// <summary>
      /// When provided in a partial class, allows value of name1 to be changed before setting.
      /// </summary>
      partial void Setname1(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name1 to be changed before returning.
      /// </summary>
      partial void Getname1(ref string result);

      public string name1
      {
         get
         {
            string value = _name1;
            Getname1(ref value);
            return (_name1 = value);
         }
         set
         {
            string oldValue = _name1;
            Setname1(oldValue, ref value);
            if (oldValue != value)
            {
               _name1 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name2
      /// </summary>
      protected string _name2;
      /// <summary>
      /// When provided in a partial class, allows value of name2 to be changed before setting.
      /// </summary>
      partial void Setname2(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name2 to be changed before returning.
      /// </summary>
      partial void Getname2(ref string result);

      public string name2
      {
         get
         {
            string value = _name2;
            Getname2(ref value);
            return (_name2 = value);
         }
         protected set
         {
            string oldValue = _name2;
            Setname2(oldValue, ref value);
            if (oldValue != value)
            {
               _name2 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name3
      /// </summary>
      protected int? _name3;
      /// <summary>
      /// When provided in a partial class, allows value of name3 to be changed before setting.
      /// </summary>
      partial void Setname3(int? oldValue, ref int? newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name3 to be changed before returning.
      /// </summary>
      partial void Getname3(ref int? result);

      public int? name3
      {
         get
         {
            int? value = _name3;
            Getname3(ref value);
            return (_name3 = value);
         }
         set
         {
            int? oldValue = _name3;
            Setname3(oldValue, ref value);
            if (oldValue != value)
            {
               _name3 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name4
      /// </summary>
      protected int? _name4;
      /// <summary>
      /// When provided in a partial class, allows value of name4 to be changed before setting.
      /// </summary>
      partial void Setname4(int? oldValue, ref int? newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name4 to be changed before returning.
      /// </summary>
      partial void Getname4(ref int? result);

      public int? name4
      {
         get
         {
            int? value = _name4;
            Getname4(ref value);
            return (_name4 = value);
         }
         protected set
         {
            int? oldValue = _name4;
            Setname4(oldValue, ref value);
            if (oldValue != value)
            {
               _name4 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name5
      /// </summary>
      protected int? _name5;
      /// <summary>
      /// When provided in a partial class, allows value of name5 to be changed before setting.
      /// </summary>
      partial void Setname5(int? oldValue, ref int? newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name5 to be changed before returning.
      /// </summary>
      partial void Getname5(ref int? result);

      public int? name5
      {
         get
         {
            int? value = _name5;
            Getname5(ref value);
            return (_name5 = value);
         }
         set
         {
            int? oldValue = _name5;
            Setname5(oldValue, ref value);
            if (oldValue != value)
            {
               _name5 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name6
      /// </summary>
      protected int? _name6;
      /// <summary>
      /// When provided in a partial class, allows value of name6 to be changed before setting.
      /// </summary>
      partial void Setname6(int? oldValue, ref int? newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name6 to be changed before returning.
      /// </summary>
      partial void Getname6(ref int? result);

      public int? name6
      {
         get
         {
            int? value = _name6;
            Getname6(ref value);
            return (_name6 = value);
         }
         protected set
         {
            int? oldValue = _name6;
            Setname6(oldValue, ref value);
            if (oldValue != value)
            {
               _name6 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name7
      /// </summary>
      protected string _name7;
      /// <summary>
      /// When provided in a partial class, allows value of name7 to be changed before setting.
      /// </summary>
      partial void Setname7(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name7 to be changed before returning.
      /// </summary>
      partial void Getname7(ref string result);

      public string name7
      {
         get
         {
            string value = _name7;
            Getname7(ref value);
            return (_name7 = value);
         }
         set
         {
            string oldValue = _name7;
            Setname7(oldValue, ref value);
            if (oldValue != value)
            {
               _name7 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name8
      /// </summary>
      protected string _name8;
      /// <summary>
      /// When provided in a partial class, allows value of name8 to be changed before setting.
      /// </summary>
      partial void Setname8(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name8 to be changed before returning.
      /// </summary>
      partial void Getname8(ref string result);

      public string name8
      {
         get
         {
            string value = _name8;
            Getname8(ref value);
            return (_name8 = value);
         }
         protected set
         {
            string oldValue = _name8;
            Setname8(oldValue, ref value);
            if (oldValue != value)
            {
               _name8 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name9
      /// </summary>
      protected string _name9;
      /// <summary>
      /// When provided in a partial class, allows value of name9 to be changed before setting.
      /// </summary>
      partial void Setname9(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name9 to be changed before returning.
      /// </summary>
      partial void Getname9(ref string result);

      public string name9
      {
         get
         {
            string value = _name9;
            Getname9(ref value);
            return (_name9 = value);
         }
         set
         {
            string oldValue = _name9;
            Setname9(oldValue, ref value);
            if (oldValue != value)
            {
               _name9 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name
      /// </summary>
      protected string _name;
      /// <summary>
      /// When provided in a partial class, allows value of name to be changed before setting.
      /// </summary>
      partial void Setname(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name to be changed before returning.
      /// </summary>
      partial void Getname(ref string result);

      public string name
      {
         get
         {
            string value = _name;
            Getname(ref value);
            return (_name = value);
         }
         protected set
         {
            string oldValue = _name;
            Setname(oldValue, ref value);
            if (oldValue != value)
            {
               _name = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name11
      /// </summary>
      protected int? _name11;
      /// <summary>
      /// When provided in a partial class, allows value of name11 to be changed before setting.
      /// </summary>
      partial void Setname11(int? oldValue, ref int? newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name11 to be changed before returning.
      /// </summary>
      partial void Getname11(ref int? result);

      public int? name11
      {
         get
         {
            int? value = _name11;
            Getname11(ref value);
            return (_name11 = value);
         }
         set
         {
            int? oldValue = _name11;
            Setname11(oldValue, ref value);
            if (oldValue != value)
            {
               _name11 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name12
      /// </summary>
      protected int? _name12;
      /// <summary>
      /// When provided in a partial class, allows value of name12 to be changed before setting.
      /// </summary>
      partial void Setname12(int? oldValue, ref int? newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name12 to be changed before returning.
      /// </summary>
      partial void Getname12(ref int? result);

      public int? name12
      {
         get
         {
            int? value = _name12;
            Getname12(ref value);
            return (_name12 = value);
         }
         protected set
         {
            int? oldValue = _name12;
            Setname12(oldValue, ref value);
            if (oldValue != value)
            {
               _name12 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name13
      /// </summary>
      protected int? _name13;
      /// <summary>
      /// When provided in a partial class, allows value of name13 to be changed before setting.
      /// </summary>
      partial void Setname13(int? oldValue, ref int? newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name13 to be changed before returning.
      /// </summary>
      partial void Getname13(ref int? result);

      public int? name13
      {
         get
         {
            int? value = _name13;
            Getname13(ref value);
            return (_name13 = value);
         }
         set
         {
            int? oldValue = _name13;
            Setname13(oldValue, ref value);
            if (oldValue != value)
            {
               _name13 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name14
      /// </summary>
      protected int? _name14;
      /// <summary>
      /// When provided in a partial class, allows value of name14 to be changed before setting.
      /// </summary>
      partial void Setname14(int? oldValue, ref int? newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name14 to be changed before returning.
      /// </summary>
      partial void Getname14(ref int? result);

      public int? name14
      {
         get
         {
            int? value = _name14;
            Getname14(ref value);
            return (_name14 = value);
         }
         protected set
         {
            int? oldValue = _name14;
            Setname14(oldValue, ref value);
            if (oldValue != value)
            {
               _name14 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name15
      /// </summary>
      protected string _name15;
      /// <summary>
      /// When provided in a partial class, allows value of name15 to be changed before setting.
      /// </summary>
      partial void Setname15(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name15 to be changed before returning.
      /// </summary>
      partial void Getname15(ref string result);

      public string name15
      {
         get
         {
            string value = _name15;
            Getname15(ref value);
            return (_name15 = value);
         }
         set
         {
            string oldValue = _name15;
            Setname15(oldValue, ref value);
            if (oldValue != value)
            {
               _name15 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name16
      /// </summary>
      protected string _name16;
      /// <summary>
      /// When provided in a partial class, allows value of name16 to be changed before setting.
      /// </summary>
      partial void Setname16(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name16 to be changed before returning.
      /// </summary>
      partial void Getname16(ref string result);

      public string name16
      {
         get
         {
            string value = _name16;
            Getname16(ref value);
            return (_name16 = value);
         }
         protected set
         {
            string oldValue = _name16;
            Setname16(oldValue, ref value);
            if (oldValue != value)
            {
               _name16 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name17
      /// </summary>
      protected string _name17;
      /// <summary>
      /// When provided in a partial class, allows value of name17 to be changed before setting.
      /// </summary>
      partial void Setname17(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name17 to be changed before returning.
      /// </summary>
      partial void Getname17(ref string result);

      public string name17
      {
         get
         {
            string value = _name17;
            Getname17(ref value);
            return (_name17 = value);
         }
         set
         {
            string oldValue = _name17;
            Setname17(oldValue, ref value);
            if (oldValue != value)
            {
               _name17 = value;
            }
         }
      }

      /// <summary>
      /// Backing field for name18
      /// </summary>
      protected string _name18;
      /// <summary>
      /// When provided in a partial class, allows value of name18 to be changed before setting.
      /// </summary>
      partial void Setname18(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of name18 to be changed before returning.
      /// </summary>
      partial void Getname18(ref string result);

      public string name18
      {
         get
         {
            string value = _name18;
            Getname18(ref value);
            return (_name18 = value);
         }
         protected set
         {
            string oldValue = _name18;
            Setname18(oldValue, ref value);
            if (oldValue != value)
            {
               _name18 = value;
            }
         }
      }

   }
}

