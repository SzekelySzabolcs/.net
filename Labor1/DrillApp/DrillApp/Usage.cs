using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Usage
{
    public bool Concrete { get; set; }
    public bool HardBrick { get; set; }
    public bool HardMaterial { get; set; }
    public bool Metal { get; set; }
    public bool Screwdriver { get; set; }
    public bool Wood { get; set; }


    public Usage()
    {
    }

    public Usage(bool concrete,
        bool hardBrick,
        bool hardMaterial,
        bool metal,
        bool screwdriver,
        bool wood)
    {
        Concrete = concrete;
        HardBrick = hardBrick;
        HardMaterial = hardMaterial;
        Metal = metal;
        Screwdriver = screwdriver;
        Wood = wood;
    }
}
