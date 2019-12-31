using System;


//族(1-18)
public enum ElementGroup
{
    G1, G2, G3, G4, G5,
    G6, G7, G8, G9, G10,
    G11, G12, G13, G14, G15,
    G16, G17, G18,
}

//周期(1-8)
public enum ElementPeriod
{
    P1, P2, P3, P4, P5, P6, P7, P8
}

public enum ElementBlock
{
    S, P, D, F, G
}

public enum ElementSymbol
{
    H, He, Li, Be, B, C, N, O, F, Ne, Na, Mg, Al, Si, P, S, Cl, Ar,
    K, Ca, Sc, Ti, V, Cr, Mn, Fe, Co, Ni, Cu, Zn, Ga, Ge,
    As, Se, Br, Kr, Rb, Sr, Y, Zr, Nb, Mo, Tc, Ru, Rh, Pd, Ag, Cd,
    In, Sn, Sb, Te, I, Xe, Cs, Ba, La, Ce, Pr, Nd, Pm, Sm,
    Eu, Gd, Tb, Dy, Ho, Er, Tm, Yb, Lu, Hf, Ta, W, Re, Os,
    Ir, Pt, Au, Hg, Tl, Pb, Bi, Po, At, Rn, Fr, Ra, Ac, Th,
    Pa, U, Np, Pu, Am, Cm, Bk, Cf, Es, Fm, Md, No, Lr, Rf,
    Db, Sg, Bh, Hs, Mt, Ds, Rg, Cn, Nh, Fl, Mc, Lv, Ts, Og
}


struct ElementCommon
{
    public readonly ElementSymbol Symbol;
    public readonly string Name;
    //原子番号
    public readonly int Number;
    //原子量
    public readonly float AtomicWeight;

    public readonly ElementGroup Group;
    public readonly ElementPeriod Period;
    public readonly ElementBlock Block;

    public ElementCommon(
        ElementSymbol Symbol,
        string Name,
        int Number,
        float AtomicWeight,
        ElementGroup Group,
        ElementPeriod Period,
        ElementBlock Block
    ){
        this.Symbol=Symbol;
        this.Name=Name;
        this.Number=Number;
        this.AtomicWeight=AtomicWeight;
        this.Group=Group;
        this.Period=Period;
        this.Block=Block;
    }

}

