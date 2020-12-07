using System;
using System.Collections.Generic;
using System.Text;

namespace Basgrupp
{
    class Medlem {
    public string namn;
    public int ålder;
    public string födelsedag;
    public string mat;
    public string band;
    public string film;
    public string älskar;
    public string hatar;
    public string stjärntecken;
    public string superkraft;
    public string driv;

    public Medlem()
    {

    }

    public Medlem(string namn, int ålder, string födelsedag, string mat, string band, string film, string älskar, string hatar, string stjärntecken, string superkraft, string driv)
    {
        this.namn = namn;
        this.ålder = ålder;
        this.födelsedag = födelsedag;
        this.mat = mat;
        this.band = band;
        this.film = film;
        this.älskar = älskar;
        this.hatar = hatar;
        this.stjärntecken = stjärntecken;
        this.superkraft = superkraft;
        this.driv = driv;
    }

    public string Namn
    {
        get { return namn; }
        set { namn = value; }
    }
    public int Ålder
    {
        get { return ålder; }
        set { ålder = value; }
    }

    public string Födelsedag
    {
        get { return födelsedag; }
        set { födelsedag = value; }
    }

    public string Mat
    {
        get { return mat; }
        set { mat = value; }
    }

    public string Band
    {
        get { return band; }
        set { band = value; }
    }

    public string Film
    {
        get { return film; }
        set { film = value; }
    }

    public string Älskar
    {
        get { return älskar; }
        set { älskar = value; }
    }

    public string Hatar
    {
        get { return hatar; }
        set { hatar = value; }
    }

    public string Stjärntecken
    {
        get { return stjärntecken; }
        set { stjärntecken = value; }
    }

    public string Superkraft
    {
        get { return superkraft; }
        set { superkraft = value; }
    }

    public string Driv
    {
        get { return driv; }
        set { driv = value; }
    }
}
}
