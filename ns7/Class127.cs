using ns6;
using System;
using System.Text;

namespace ns7
{
	public class Class127 : Class121
	{
		public Class142[] class142_0;

		public Class127(Class144 class144_0, int int_0, bool bool_1) : base(bool_1)
		{
			int num = int_0 / 18;
			this.class142_0 = new Class142[num];
			for (int i = 0; i < this.class142_0.Length; i++)
			{
				this.class142_0[i] = new Class142(class144_0);
			}
			int_0 -= int_0 * 18;
			if (int_0 > 0)
			{
				class144_0.vmethod_15(null, int_0);
			}
		}

		public virtual int vmethod_1()
		{
			return this.class142_0.Length;
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SeekTable: points=" + this.class142_0.Length + "\n");
			for (int i = 0; i < this.class142_0.Length; i++)
			{
				stringBuilder.Append("\tPoint " + this.class142_0[i].ToString() + "\n");
			}
			return stringBuilder.ToString();
		}
	}
}
