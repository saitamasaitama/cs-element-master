using System;

enum ElementPhysicsPhase{
    PLASMA,
    GAS,
    LIQUID,
    SOLID,
}
//原子
struct ElementPhysics{
    public ElementPhysicsPhase Phase(float degree){
        return ElementPhysicsPhase.SOLID;
    }
    //密度
    public float SolidDense;
    public float LiquidDense;
    //融点    
    public float MeltingPoint;
    //沸点
    public float BoilingPoint;
    //熱容量
    public float Capacity;

    public static Element Iron=>new Element(){
        Symbol="",

    };
}


