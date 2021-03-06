using System;

namespace ns1
{
	public struct Struct12 : IComparable, ICloneable
	{
		public double double_0;

		public double double_1;

		public Struct12(Struct12 struct12_0)
		{
			this.double_0 = struct12_0.double_0;
			this.double_1 = struct12_0.double_1;
		}

		object ICloneable.Clone()
		{
			return new Struct12(this);
		}

		public double method_0()
		{
			double num = this.double_0;
			double num2 = this.double_1;
			return Math.Sqrt(num * num + num2 * num2);
		}

		public static bool smethod_0(Struct12 struct12_0, Struct12 struct12_1)
		{
			return struct12_0.double_0 == struct12_1.double_0 && struct12_0.double_1 == struct12_1.double_1;
		}

		public override int GetHashCode()
		{
			return this.double_0.GetHashCode() ^ this.double_1.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (obj is Struct12)
			{
				Struct12 struct12_ = (Struct12)obj;
				return Struct12.smethod_0(this, struct12_);
			}
			return false;
		}

		public int CompareTo(object target)
		{
			if (target == null)
			{
				return 1;
			}
			if (target is Struct12)
			{
				return this.method_0().CompareTo(((Struct12)target).method_0());
			}
			if (target is double)
			{
				return this.method_0().CompareTo((double)target);
			}
			if (target is Struct10)
			{
				return this.method_0().CompareTo((double)((Struct10)target).method_0());
			}
			if (!(target is float))
			{
				throw new ArgumentException();
			}
			return this.method_0().CompareTo((double)((float)target));
		}

		public override string ToString()
		{
			return string.Format("( {0}, {1}i )", this.double_0, this.double_1);
		}
	}
}
