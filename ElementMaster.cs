using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

//原子
partial struct Element{
    ElementCommon common;
    ElementPhysics physics;
    public string Symbol=>common.Symbol.ToString();
    public string Name=>common.Name;

    public Element(ElementCommon common,ElementPhysics physics){
        this.common=common;
        this.physics=physics;
    }

    public static List<Element> FromMaster(){
        List<Element> result=new List<Element>();
        //TSV
        

        return result;
    }
}

