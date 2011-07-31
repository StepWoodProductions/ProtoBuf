﻿//
//	You may customize this code as you like
//	Report bugs to: https://silentorbit.com/protobuf-csharpgen/
//
//	Generated by ProtocolBuffer
//	- a pure c# code generation implementation of protocol buffers
//

using System;
using System.Collections.Generic;

namespace Personal
{
	public partial class Person
	{
		public enum PhoneType
		{
			MOBILE = 0,
			HOME = 1,
			WORK = 2,
		}
	
		public string Name { get; set; }
		public int Id { get; set; }
		public string Email { get; set; }
		public List<Personal.Person.PhoneNumber> Phone { get; set; }
	
		public Person()
		{
			this.Email = "";
			this.Phone = new List<Personal.Person.PhoneNumber>();
		}
	
		protected virtual void BeforeSerialize()
		{
		}
	
		protected virtual void AfterDeserialize()
		{
		}
	
		public partial class PhoneNumber
		{
			public string Number { get; set; }
			public Personal.Person.PhoneType Type { get; set; }
		
			public PhoneNumber()
			{
				this.Type = Personal.Person.PhoneType.HOME;
			}
		
			protected virtual void BeforeSerialize()
			{
			}
		
			protected virtual void AfterDeserialize()
			{
			}
		}
	}

}
namespace Mine
{
	public partial class MyMessageV1
	{
		public int FieldA { get; set; }
	
		public MyMessageV1()
		{
		}
	
		protected virtual void BeforeSerialize()
		{
		}
	
		protected virtual void AfterDeserialize()
		{
		}
	}

}
namespace Yours
{
	public partial class MyMessageV2
	{
		public enum MyEnum
		{
			ETest1 = 0,
			ETest2 = 3,
			ETest3 = 2,
		}
	
		public int FieldA { get; set; }
		public double FieldB { get; set; }
		public float FieldC { get; set; }
		public int FieldD { get; set; }
		public long FieldE { get; set; }
		public uint FieldF { get; set; }
		public ulong FieldG { get; set; }
		public int FieldH { get; set; }
		public long FieldI { get; set; }
		public uint FieldJ { get; set; }
		public ulong FieldK { get; set; }
		public int FieldL { get; set; }
		public long FieldM { get; set; }
		public bool FieldN { get; set; }
		public string FieldO { get; set; }
		public byte[] FieldP { get; set; }
		public Yours.MyMessageV2.MyEnum FieldQ { get; set; }
		public Yours.MyMessageV2.MyEnum FieldR { get; set; }
		protected string Dummy { get; set; }
		public List<uint> FieldS { get; set; }
		public List<uint> FieldT { get; set; }
		public Theirs.TheirMessage FieldU { get; set; }
		public List<Theirs.TheirMessage> FieldV { get; set; }
	
		public MyMessageV2()
		{
			this.FieldR = Yours.MyMessageV2.MyEnum.ETest2;
			this.Dummy = "";
			this.FieldS = new List<uint>();
			this.FieldT = new List<uint>();
			this.FieldV = new List<Theirs.TheirMessage>();
		}
	
		protected virtual void BeforeSerialize()
		{
		}
	
		protected virtual void AfterDeserialize()
		{
		}
	}

}
namespace Theirs
{
	public partial class TheirMessage
	{
		public int FieldA { get; set; }
	
		public TheirMessage()
		{
		}
	
		protected virtual void BeforeSerialize()
		{
		}
	
		protected virtual void AfterDeserialize()
		{
		}
	}

}
