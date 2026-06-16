public class PhanSo
{
    public int TuSo  { get; private set; }
    public int MauSo { get; private set; }
 
    public PhanSo(int tuSo, int mauSo)
    {
        if (mauSo == 0)
            throw new ArgumentException("Mau so khong duoc bang 0!");
 
        // Chuan hoa dau: dua dau am len tu so
        if (mauSo < 0) { tuSo = -tuSo; mauSo = -mauSo; }
 
        int ucln = UCLN(Math.Abs(tuSo), mauSo);
        TuSo  = tuSo  / ucln;
        MauSo = mauSo / ucln;
    }
 
    // Tinh uoc chung lon nhat bang thuat toan Euclid
    private static int UCLN(int a, int b)
    {
        while (b != 0) { int t = b; b = a % b; a = t; }
        return (a == 0) ? 1 : a;
    }
 
    // Constructor da tu dong rut gon nen chi can tao moi
    public PhanSo RutGon() => new PhanSo(TuSo, MauSo);
 
    public override string ToString()
    {
        if (MauSo == 1) return TuSo.ToString();
        return $"{TuSo}/{MauSo}";
    }
 
    // Toan tu so hoc
    public static PhanSo operator +(PhanSo a, PhanSo b)
        => new PhanSo(a.TuSo * b.MauSo + b.TuSo * a.MauSo, a.MauSo * b.MauSo);
 
    public static PhanSo operator -(PhanSo a, PhanSo b)
        => new PhanSo(a.TuSo * b.MauSo - b.TuSo * a.MauSo, a.MauSo * b.MauSo);
 
    public static PhanSo operator *(PhanSo a, PhanSo b)
        => new PhanSo(a.TuSo * b.TuSo, a.MauSo * b.MauSo);
 
    public static PhanSo operator /(PhanSo a, PhanSo b)
    {
        if (b.TuSo == 0)
            throw new DivideByZeroException("Khong the chia cho phan so bang 0!");
        return new PhanSo(a.TuSo * b.MauSo, a.MauSo * b.TuSo);
    }
 
    // Cong phan so voi so nguyen
    public static PhanSo operator +(PhanSo a, int n)
        => new PhanSo(a.TuSo + n * a.MauSo, a.MauSo);
 
    public static PhanSo operator +(int n, PhanSo a)
        => a + n;
 
    // Toan tu so sanh
    private static int Compare(PhanSo a, PhanSo b)
    {
        long lhs = (long)a.TuSo * b.MauSo;
        long rhs = (long)b.TuSo * a.MauSo;
        return lhs.CompareTo(rhs);
    }
 
    // Constructor da rut gon nen so sanh truc tiep TuSo va MauSo la dung
    public static bool operator ==(PhanSo a, PhanSo b)
        => a.TuSo == b.TuSo && a.MauSo == b.MauSo;
 
    public static bool operator !=(PhanSo a, PhanSo b) => !(a == b);
 
    public static bool operator <(PhanSo a, PhanSo b)  => Compare(a, b) < 0;
    public static bool operator >(PhanSo a, PhanSo b)  => Compare(a, b) > 0;
    public static bool operator <=(PhanSo a, PhanSo b) => Compare(a, b) <= 0;
    public static bool operator >=(PhanSo a, PhanSo b) => Compare(a, b) >= 0;
 
    public override bool Equals(object? obj)
        => obj is PhanSo other && this == other;
 
    public override int GetHashCode()
        => HashCode.Combine(TuSo, MauSo);
}