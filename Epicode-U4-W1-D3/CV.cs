using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Epicode_U4_W1_D3
{
    internal class CV
    {
        #region Paramethers
        public InformazioniPersonali Info { get; set; }
        public List<Studi> StudiList { get; set; }
        public Impiego Impiego { get; set; }
        #endregion

        #region Costructors
        public CV(string nome, string cognome) 
        {
            Info = new InformazioniPersonali(nome, cognome);
            Impiego = new Impiego();
            StudiList = new List<Studi>();
        }
        public CV(string nome, string cognome, string telefono)
        {
            Info = new InformazioniPersonali(nome, cognome, telefono);
            Impiego = new Impiego();
            StudiList = new List<Studi>();
        }
        public CV(string nome, string cognome, string telefono, string email)
        {
            Info = new InformazioniPersonali(nome, cognome, telefono, email);
            Impiego = new Impiego();
            StudiList = new List<Studi>();
        }
        #endregion

        #region Methods 

        #region Informazioni
        public void updateTelefono( string telefono)
        {
            Info.Telefono = telefono;
        }
        public void updateEmail(string email)
        {
            Info.Email = email;
        }
        #endregion

        #region Studi
        public void addStudi(string qualifica, string istituto, string tipo, string dal)
        {
            StudiList.Add(new Studi(qualifica, istituto, tipo, dal));
        }
        public void addStudi(string qualifica, string istituto, string tipo, string dal, string al)
        {
            StudiList.Add(new Studi(qualifica, istituto, tipo, dal, al));
        }
        public void removeStudi(int index)
        { 
            StudiList.RemoveAt(index); 
        }
        #endregion

        #region Impieghi

        public void addImpiego(string azienda, string jobTitlte, string descrizione, string dal)
        {
            Impiego.addEsperienza(azienda, jobTitlte, descrizione, dal);
        }
        public void addImpiego(string azienda, string jobTitlte, string descrizione, string dal, string al)
        {
            Impiego.addEsperienza(azienda, jobTitlte, descrizione, dal, al);
        }
        public void removeImpiego(int index)
        {
            Impiego.removeEsperienza(index);
        }

        #endregion

        #endregion

    }

    class InformazioniPersonali
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        #region Constructors
        public InformazioniPersonali(string nome, string congnome) 
        {
            Nome = nome;
            Cognome = congnome;
        }
        public InformazioniPersonali(string nome, string cognome, string telefono): this(nome, cognome)
        { 
            Telefono = telefono;
        }
        public InformazioniPersonali(string nome, string cognome, string telefono, string email): this(nome, cognome, telefono)
        {
            Email = email;
        }
        #endregion
    }

    class Studi
    {
        public string Qualifica { get; set;}
        public string Istituto { get; set;}
        public string Tipo { get; set;}
        public string Dal { get; set;}
        public string Al { get; set;}

        #region Constructors
        public Studi(string qualifica, string istituto, string tipo, string dal)
        {
            Qualifica = qualifica;
            Istituto = istituto;
            Tipo = tipo;
            Dal = dal;
        }
        public Studi(string qualifica, string istituto, string tipo, string dal, string al)
         :this(qualifica, istituto, tipo, dal)
        {
            Al = al;
        }
        #endregion

        #region Methods
        public void updateStudi(string qualifica, string istituto, string tipo, string dal, string al)
        {
            Qualifica = qualifica;
            Istituto  = istituto;
            Tipo      = tipo;    
            Dal       = dal;
            Al        = al;
        }
        #endregion
    }

    class Esperienza
    {
        public string Azienda { get; set; }
        public string JobTitle { get; set; }
        public string Dal { get; set; }
        public string Al { get; set; }
        public string Descrizione { get; set; }
        public List<string> Compiti { get; set; }

        #region Constructors
        public Esperienza(string azienda, string jobTitlte, string descrizione, string dal)
        {
            Azienda = azienda;
            JobTitle = jobTitlte;
            Descrizione = descrizione;
            Dal = dal;
            Compiti = new List<string>();
        }
        public Esperienza(string azienda, string jobTitlte, string descrizione, string dal, string al): this(azienda, jobTitlte, descrizione, dal)
        { 
            Al = al;
        }
        #endregion

        public void addCompito(string compito)
        { 
            Compiti.Add(compito);
        }
    }

    class Impiego
    {
        public List<Esperienza> Esperienze { get; set; }

        public Impiego()
        {
            Esperienze = new List<Esperienza>();
        }

        #region Methods
        public void addEsperienza(string azienda, string jobTitlte, string descrizione, string dal, string al)
        {
            Esperienze.Add(new Esperienza(azienda, jobTitlte,descrizione, dal, al));
        }
        public void addEsperienza(string azienda, string jobTitlte, string descrizione, string dal)
        {
            Esperienze.Add(new Esperienza(azienda, jobTitlte, descrizione, dal));
        }
        public void removeEsperienza(int index)
        { 
            Esperienze.RemoveAt(index);
        }
        #endregion
    }
}
