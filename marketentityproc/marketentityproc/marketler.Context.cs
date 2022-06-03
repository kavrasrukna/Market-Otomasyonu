﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace marketentityproc
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class marketEntities : DbContext
    {
        public marketEntities()
            : base("name=marketEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<elemanlar> elemanlars { get; set; }
        public virtual DbSet<gorevler> gorevlers { get; set; }
        public virtual DbSet<kullanicilar> kullanicilars { get; set; }
    
        public virtual ObjectResult<elemanara_Result> elemanara(string elemanadi)
        {
            var elemanadiParameter = elemanadi != null ?
                new ObjectParameter("elemanadi", elemanadi) :
                new ObjectParameter("elemanadi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<elemanara_Result>("elemanara", elemanadiParameter);
        }
    
        public virtual int elemanekle(string elemanadi, string elemanpozisyon, Nullable<decimal> elemanmaas, string elemanstatu, Nullable<int> gorevno)
        {
            var elemanadiParameter = elemanadi != null ?
                new ObjectParameter("elemanadi", elemanadi) :
                new ObjectParameter("elemanadi", typeof(string));
    
            var elemanpozisyonParameter = elemanpozisyon != null ?
                new ObjectParameter("elemanpozisyon", elemanpozisyon) :
                new ObjectParameter("elemanpozisyon", typeof(string));
    
            var elemanmaasParameter = elemanmaas.HasValue ?
                new ObjectParameter("elemanmaas", elemanmaas) :
                new ObjectParameter("elemanmaas", typeof(decimal));
    
            var elemanstatuParameter = elemanstatu != null ?
                new ObjectParameter("elemanstatu", elemanstatu) :
                new ObjectParameter("elemanstatu", typeof(string));
    
            var gorevnoParameter = gorevno.HasValue ?
                new ObjectParameter("gorevno", gorevno) :
                new ObjectParameter("gorevno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("elemanekle", elemanadiParameter, elemanpozisyonParameter, elemanmaasParameter, elemanstatuParameter, gorevnoParameter);
        }
    
        public virtual ObjectResult<elemanlistele_Result> elemanlistele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<elemanlistele_Result>("elemanlistele");
        }
    
        public virtual int elemansil(Nullable<int> elemanno)
        {
            var elemannoParameter = elemanno.HasValue ?
                new ObjectParameter("elemanno", elemanno) :
                new ObjectParameter("elemanno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("elemansil", elemannoParameter);
        }
    
        public virtual int elemanyenile(Nullable<int> elemanno, string elemanadi, string elemanpozisyon, Nullable<decimal> elemanmaas, string elemanstatu, Nullable<int> gorevno)
        {
            var elemannoParameter = elemanno.HasValue ?
                new ObjectParameter("elemanno", elemanno) :
                new ObjectParameter("elemanno", typeof(int));
    
            var elemanadiParameter = elemanadi != null ?
                new ObjectParameter("elemanadi", elemanadi) :
                new ObjectParameter("elemanadi", typeof(string));
    
            var elemanpozisyonParameter = elemanpozisyon != null ?
                new ObjectParameter("elemanpozisyon", elemanpozisyon) :
                new ObjectParameter("elemanpozisyon", typeof(string));
    
            var elemanmaasParameter = elemanmaas.HasValue ?
                new ObjectParameter("elemanmaas", elemanmaas) :
                new ObjectParameter("elemanmaas", typeof(decimal));
    
            var elemanstatuParameter = elemanstatu != null ?
                new ObjectParameter("elemanstatu", elemanstatu) :
                new ObjectParameter("elemanstatu", typeof(string));
    
            var gorevnoParameter = gorevno.HasValue ?
                new ObjectParameter("gorevno", gorevno) :
                new ObjectParameter("gorevno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("elemanyenile", elemannoParameter, elemanadiParameter, elemanpozisyonParameter, elemanmaasParameter, elemanstatuParameter, gorevnoParameter);
        }
    
        public virtual ObjectResult<gorevara_Result> gorevara(string gorevadi)
        {
            var gorevadiParameter = gorevadi != null ?
                new ObjectParameter("gorevadi", gorevadi) :
                new ObjectParameter("gorevadi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<gorevara_Result>("gorevara", gorevadiParameter);
        }
    
        public virtual int gorevekle(string gorevadi, string gorevtanimi, Nullable<decimal> gorevfiyat, string gorevsuresi, string gorevdurum)
        {
            var gorevadiParameter = gorevadi != null ?
                new ObjectParameter("gorevadi", gorevadi) :
                new ObjectParameter("gorevadi", typeof(string));
    
            var gorevtanimiParameter = gorevtanimi != null ?
                new ObjectParameter("gorevtanimi", gorevtanimi) :
                new ObjectParameter("gorevtanimi", typeof(string));
    
            var gorevfiyatParameter = gorevfiyat.HasValue ?
                new ObjectParameter("gorevfiyat", gorevfiyat) :
                new ObjectParameter("gorevfiyat", typeof(decimal));
    
            var gorevsuresiParameter = gorevsuresi != null ?
                new ObjectParameter("gorevsuresi", gorevsuresi) :
                new ObjectParameter("gorevsuresi", typeof(string));
    
            var gorevdurumParameter = gorevdurum != null ?
                new ObjectParameter("gorevdurum", gorevdurum) :
                new ObjectParameter("gorevdurum", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("gorevekle", gorevadiParameter, gorevtanimiParameter, gorevfiyatParameter, gorevsuresiParameter, gorevdurumParameter);
        }
    
        public virtual ObjectResult<gorevlistele_Result> gorevlistele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<gorevlistele_Result>("gorevlistele");
        }
    
        public virtual int gorevsil(Nullable<int> gorevno)
        {
            var gorevnoParameter = gorevno.HasValue ?
                new ObjectParameter("gorevno", gorevno) :
                new ObjectParameter("gorevno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("gorevsil", gorevnoParameter);
        }
    
        public virtual int gorevyenile(Nullable<int> gorevno, string gorevadi, string gorevtanimi, Nullable<decimal> gorevfiyat, string gorevsuresi, string gorevdurum)
        {
            var gorevnoParameter = gorevno.HasValue ?
                new ObjectParameter("gorevno", gorevno) :
                new ObjectParameter("gorevno", typeof(int));
    
            var gorevadiParameter = gorevadi != null ?
                new ObjectParameter("gorevadi", gorevadi) :
                new ObjectParameter("gorevadi", typeof(string));
    
            var gorevtanimiParameter = gorevtanimi != null ?
                new ObjectParameter("gorevtanimi", gorevtanimi) :
                new ObjectParameter("gorevtanimi", typeof(string));
    
            var gorevfiyatParameter = gorevfiyat.HasValue ?
                new ObjectParameter("gorevfiyat", gorevfiyat) :
                new ObjectParameter("gorevfiyat", typeof(decimal));
    
            var gorevsuresiParameter = gorevsuresi != null ?
                new ObjectParameter("gorevsuresi", gorevsuresi) :
                new ObjectParameter("gorevsuresi", typeof(string));
    
            var gorevdurumParameter = gorevdurum != null ?
                new ObjectParameter("gorevdurum", gorevdurum) :
                new ObjectParameter("gorevdurum", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("gorevyenile", gorevnoParameter, gorevadiParameter, gorevtanimiParameter, gorevfiyatParameter, gorevsuresiParameter, gorevdurumParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<goreveleman_Result> goreveleman()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<goreveleman_Result>("goreveleman");
        }
    
        public virtual ObjectResult<goreveleman2_Result> goreveleman2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<goreveleman2_Result>("goreveleman2");
        }
    
        public virtual ObjectResult<goreveleman3_Result> goreveleman3()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<goreveleman3_Result>("goreveleman3");
        }
    
        public virtual ObjectResult<gorev1_Result> gorev1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<gorev1_Result>("gorev1");
        }
    
        public virtual int kullaniciekle(string kullaniciadi, string sifre, string mail, string telefon)
        {
            var kullaniciadiParameter = kullaniciadi != null ?
                new ObjectParameter("kullaniciadi", kullaniciadi) :
                new ObjectParameter("kullaniciadi", typeof(string));
    
            var sifreParameter = sifre != null ?
                new ObjectParameter("sifre", sifre) :
                new ObjectParameter("sifre", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("telefon", telefon) :
                new ObjectParameter("telefon", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("kullaniciekle", kullaniciadiParameter, sifreParameter, mailParameter, telefonParameter);
        }
    
        public virtual ObjectResult<kullanicigiris_Result> kullanicigiris(string kullaniciadi, string sifre)
        {
            var kullaniciadiParameter = kullaniciadi != null ?
                new ObjectParameter("kullaniciadi", kullaniciadi) :
                new ObjectParameter("kullaniciadi", typeof(string));
    
            var sifreParameter = sifre != null ?
                new ObjectParameter("sifre", sifre) :
                new ObjectParameter("sifre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<kullanicigiris_Result>("kullanicigiris", kullaniciadiParameter, sifreParameter);
        }
    
        public virtual ObjectResult<gorevmaas_Result> gorevmaas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<gorevmaas_Result>("gorevmaas");
        }
    
        public virtual ObjectResult<Nullable<decimal>> gorevstatü()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("gorevstatü");
        }
    
        public virtual ObjectResult<string> gorevsure()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("gorevsure");
        }
    }
}
