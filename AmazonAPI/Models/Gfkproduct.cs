using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Gfkproduct
{
    public int Productid { get; set; }

    public int Manufacturerid { get; set; }

    public bool Isactive { get; set; }

    public string Mfgpartno { get; set; } = null!;

    public int Categoryid { get; set; }

    public bool Isaccessory { get; set; }

    public double Equivalency { get; set; }

    public DateTime? Creationdate { get; set; }

    public DateTime? Modifieddate { get; set; }

    public DateTime? Lastupdated { get; set; }
}
