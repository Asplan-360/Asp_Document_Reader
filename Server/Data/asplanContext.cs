using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Asp_Document_Reader.Server.Data
{
    public partial class asplanContext : DbContext
    {
        public asplanContext()
        {
        }

        public asplanContext(DbContextOptions<asplanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aniversariante> Aniversariantes { get; set; } = null!;
        public virtual DbSet<AspNetMail> AspNetMails { get; set; } = null!;
        public virtual DbSet<BaseImp> BaseImps { get; set; } = null!;
        public virtual DbSet<BkpTbCadastroEmpresa> BkpTbCadastroEmpresas { get; set; } = null!;
        public virtual DbSet<ContO> ContOs { get; set; } = null!;
        public virtual DbSet<Coreme201118092012> Coreme201118092012s { get; set; } = null!;
        public virtual DbSet<Dtproperty> Dtproperties { get; set; } = null!;
        public virtual DbSet<EfciLogMkt> EfciLogMkts { get; set; } = null!;
        public virtual DbSet<EfciLogMktLido> EfciLogMktLidos { get; set; } = null!;
        public virtual DbSet<EfciVisita> EfciVisitas { get; set; } = null!;
        public virtual DbSet<Ficha> Fichas { get; set; } = null!;
        public virtual DbSet<Ficha03102011> Ficha03102011s { get; set; } = null!;
        public virtual DbSet<Ficha03102011New> Ficha03102011News { get; set; } = null!;
        public virtual DbSet<Ficha14102011> Ficha14102011s { get; set; } = null!;
        public virtual DbSet<Ficha2012> Ficha2012s { get; set; } = null!;
        public virtual DbSet<FichaAux1711> FichaAux1711s { get; set; } = null!;
        public virtual DbSet<Fichacoreme> Fichacoremes { get; set; } = null!;
        public virtual DbSet<GerMenu> GerMenus { get; set; } = null!;
        public virtual DbSet<GerRotina> GerRotinas { get; set; } = null!;
        public virtual DbSet<IntraAdmAcesso> IntraAdmAcessos { get; set; } = null!;
        public virtual DbSet<IntraAdmLogalt> IntraAdmLogalts { get; set; } = null!;
        public virtual DbSet<IntraAfago> IntraAfagos { get; set; } = null!;
        public virtual DbSet<IntraAgendamento> IntraAgendamentos { get; set; } = null!;
        public virtual DbSet<IntraAnexoPonto> IntraAnexoPontos { get; set; } = null!;
        public virtual DbSet<IntraAvaliacaoCurso> IntraAvaliacaoCursos { get; set; } = null!;
        public virtual DbSet<IntraBeneficio> IntraBeneficios { get; set; } = null!;
        public virtual DbSet<IntraBeneficiosCategorium> IntraBeneficiosCategoria { get; set; } = null!;
        public virtual DbSet<IntraCategoriaLink> IntraCategoriaLinks { get; set; } = null!;
        public virtual DbSet<IntraCensurada> IntraCensuradas { get; set; } = null!;
        public virtual DbSet<IntraCiclo> IntraCiclos { get; set; } = null!;
        public virtual DbSet<IntraCicloInsc> IntraCicloInscs { get; set; } = null!;
        public virtual DbSet<IntraComentario> IntraComentarios { get; set; } = null!;
        public virtual DbSet<IntraComite> IntraComites { get; set; } = null!;
        public virtual DbSet<IntraComunicado> IntraComunicados { get; set; } = null!;
        public virtual DbSet<IntraConquistum> IntraConquista { get; set; } = null!;
        public virtual DbSet<IntraConvenio> IntraConvenios { get; set; } = null!;
        public virtual DbSet<IntraCurso> IntraCursos { get; set; } = null!;
        public virtual DbSet<IntraDepartamento> IntraDepartamentos { get; set; } = null!;
        public virtual DbSet<IntraDepartamentoxgestor> IntraDepartamentoxgestors { get; set; } = null!;
        public virtual DbSet<IntraDica> IntraDicas { get; set; } = null!;
        public virtual DbSet<IntraEmpresaExterno> IntraEmpresaExternos { get; set; } = null!;
        public virtual DbSet<IntraEnquete> IntraEnquetes { get; set; } = null!;
        public virtual DbSet<IntraEnqueteLog> IntraEnqueteLogs { get; set; } = null!;
        public virtual DbSet<IntraExterno> IntraExternos { get; set; } = null!;
        public virtual DbSet<IntraFoto> IntraFotos { get; set; } = null!;
        public virtual DbSet<IntraFotosPqec> IntraFotosPqecs { get; set; } = null!;
        public virtual DbSet<IntraFrase> IntraFrases { get; set; } = null!;
        public virtual DbSet<IntraFuncionario> IntraFuncionarios { get; set; } = null!;
        public virtual DbSet<IntraGestor> IntraGestors { get; set; } = null!;
        public virtual DbSet<IntraJornal> IntraJornals { get; set; } = null!;
        public virtual DbSet<IntraLeitura> IntraLeituras { get; set; } = null!;
        public virtual DbSet<IntraLink> IntraLinks { get; set; } = null!;
        public virtual DbSet<IntraLogAcesso> IntraLogAcessos { get; set; } = null!;
        public virtual DbSet<IntraLogAtualiza> IntraLogAtualizas { get; set; } = null!;
        public virtual DbSet<IntraLogAtualiza1> IntraLogAtualizas1 { get; set; } = null!;
        public virtual DbSet<IntraLogoFormPonto> IntraLogoFormPontos { get; set; } = null!;
        public virtual DbSet<IntraManual> IntraManuals { get; set; } = null!;
        public virtual DbSet<IntraMensagen> IntraMensagens { get; set; } = null!;
        public virtual DbSet<IntraMercado> IntraMercados { get; set; } = null!;
        public virtual DbSet<IntraMercadoCategorium> IntraMercadoCategoria { get; set; } = null!;
        public virtual DbSet<IntraNotCategorium> IntraNotCategoria { get; set; } = null!;
        public virtual DbSet<IntraNoticia> IntraNoticias { get; set; } = null!;
        public virtual DbSet<IntraPermisso> IntraPermissoes { get; set; } = null!;
        public virtual DbSet<IntraPonto> IntraPontos { get; set; } = null!;
        public virtual DbSet<IntraPqec> IntraPqecs { get; set; } = null!;
        public virtual DbSet<IntraResciso> IntraRescisoes { get; set; } = null!;
        public virtual DbSet<IntraVaga> IntraVagas { get; set; } = null!;
        public virtual DbSet<IntraVideo> IntraVideos { get; set; } = null!;
        public virtual DbSet<Matriculaproec> Matriculaproecs { get; set; } = null!;
        public virtual DbSet<Nape> Napes { get; set; } = null!;
        public virtual DbSet<ProexBkp300908> ProexBkp300908s { get; set; } = null!;
        public virtual DbSet<ProexBkpFicha> ProexBkpFichas { get; set; } = null!;
        public virtual DbSet<ProexCopia2911> ProexCopia2911s { get; set; } = null!;
        public virtual DbSet<ProexCoreme07> ProexCoreme07s { get; set; } = null!;
        public virtual DbSet<ProexCoreme08> ProexCoreme08s { get; set; } = null!;
        public virtual DbSet<ProexFichax> ProexFichaxes { get; set; } = null!;
        public virtual DbSet<Servico> Servicos { get; set; } = null!;
        public virtual DbSet<Sessao> Sessaos { get; set; } = null!;
        public virtual DbSet<SysTbComunicado> SysTbComunicados { get; set; } = null!;
        public virtual DbSet<SysTbComunicadosBodyMail> SysTbComunicadosBodyMails { get; set; } = null!;
        public virtual DbSet<SysTbComunicadosLog> SysTbComunicadosLogs { get; set; } = null!;
        public virtual DbSet<SysTbComunicadosTemp> SysTbComunicadosTemps { get; set; } = null!;
        public virtual DbSet<SysTbEmailComunicado> SysTbEmailComunicados { get; set; } = null!;
        public virtual DbSet<SysTbEnquete> SysTbEnquetes { get; set; } = null!;
        public virtual DbSet<SysTbLogin> SysTbLogins { get; set; } = null!;
        public virtual DbSet<SysTbPermisso> SysTbPermissoes { get; set; } = null!;
        public virtual DbSet<SysTbPermisssoesCategorium> SysTbPermisssoesCategoria { get; set; } = null!;
        public virtual DbSet<SysTbRelatorioTemp> SysTbRelatorioTemps { get; set; } = null!;
        public virtual DbSet<TbCadastroEmpresa> TbCadastroEmpresas { get; set; } = null!;
        public virtual DbSet<TbCadastroUsuario> TbCadastroUsuarios { get; set; } = null!;
        public virtual DbSet<TbCidade> TbCidades { get; set; } = null!;
        public virtual DbSet<TbConsultoriaUser> TbConsultoriaUsers { get; set; } = null!;
        public virtual DbSet<TbCurso> TbCursos { get; set; } = null!;
        public virtual DbSet<TbCursoData> TbCursoDatas { get; set; } = null!;
        public virtual DbSet<TbCursoInsc> TbCursoInscs { get; set; } = null!;
        public virtual DbSet<TbDocumentacaoCategorium> TbDocumentacaoCategoria { get; set; } = null!;
        public virtual DbSet<TbDocumentacaoSub> TbDocumentacaoSubs { get; set; } = null!;
        public virtual DbSet<TbEnquete> TbEnquetes { get; set; } = null!;
        public virtual DbSet<TbEstado> TbEstados { get; set; } = null!;
        public virtual DbSet<TbLayout> TbLayouts { get; set; } = null!;
        public virtual DbSet<TbLog> TbLogs { get; set; } = null!;
        public virtual DbSet<TbLogAnuncio> TbLogAnuncios { get; set; } = null!;
        public virtual DbSet<TbLogContato> TbLogContatos { get; set; } = null!;
        public virtual DbSet<TbLogEmpresa> TbLogEmpresas { get; set; } = null!;
        public virtual DbSet<TbLogTreinamento> TbLogTreinamentos { get; set; } = null!;
        public virtual DbSet<TbMensagem> TbMensagems { get; set; } = null!;
        public virtual DbSet<TbMenuCategoriaSoluco> TbMenuCategoriaSolucoes { get; set; } = null!;
        public virtual DbSet<TbMenuCategoriaSuporte> TbMenuCategoriaSuportes { get; set; } = null!;
        public virtual DbSet<TbMenuHome> TbMenuHomes { get; set; } = null!;
        public virtual DbSet<TbMenuSoluco> TbMenuSolucoes { get; set; } = null!;
        public virtual DbSet<TbMenuSuporte> TbMenuSuportes { get; set; } = null!;
        public virtual DbSet<TbModulo> TbModulos { get; set; } = null!;
        public virtual DbSet<TbNewsletter> TbNewsletters { get; set; } = null!;
        public virtual DbSet<TbOcultaAviso> TbOcultaAvisos { get; set; } = null!;
        public virtual DbSet<TbPlanewsFoto> TbPlanewsFotos { get; set; } = null!;
        public virtual DbSet<TbSistemaAtualiza> TbSistemaAtualizas { get; set; } = null!;
        public virtual DbSet<TbSoluco> TbSolucoes { get; set; } = null!;
        public virtual DbSet<TbSolucoesFoto> TbSolucoesFotos { get; set; } = null!;
        public virtual DbSet<TbTempBloqueium> TbTempBloqueia { get; set; } = null!;
        public virtual DbSet<TbTexto> TbTextos { get; set; } = null!;
        public virtual DbSet<TbTreinamento> TbTreinamentos { get; set; } = null!;
        public virtual DbSet<TbUtilitario> TbUtilitarios { get; set; } = null!;
        public virtual DbSet<Tempodecasa> Tempodecasas { get; set; } = null!;
        public virtual DbSet<ViewGerMenu> ViewGerMenus { get; set; } = null!;
        public virtual DbSet<VwPontoAprovado> VwPontoAprovados { get; set; } = null!;
        public virtual DbSet<VwPontoGestor> VwPontoGestors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=138.97.105.135;database=asplan;User=asplan2;Password=setasp@3305");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("asplan");

            modelBuilder.Entity<Aniversariante>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Aniversariantes");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("departamento");

                entity.Property(e => e.DtAniversario)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAniversario");

                entity.Property(e => e.Nome)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<AspNetMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AspNetMail", "dbo");

                entity.Property(e => e.Codi).HasColumnName("codi");

                entity.Property(e => e.Conteudo)
                    .HasColumnType("text")
                    .HasColumnName("conteudo");

                entity.Property(e => e.Emp)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("emp");
            });

            modelBuilder.Entity<BaseImp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BaseImp", "dbo");

                entity.Property(e => e.Check).HasColumnName("check");

                entity.Property(e => e.Codi).HasColumnName("codi");

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mode");

                entity.Property(e => e.Nome)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.SubTitulo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("subTitulo");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<BkpTbCadastroEmpresa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BKP_tb_cadastroEmpresa", "dbo");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cnpj");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Contato)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contato");

                entity.Property(e => e.EmailResponsavel)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("email_responsavel");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.Fantasia)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("fantasia");

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("fax");

                entity.Property(e => e.Fone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("fone");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.InscEstadual)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inscEstadual");

                entity.Property(e => e.InscMunicipal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inscMunicipal");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("login");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("observacao");

                entity.Property(e => e.Responsavel)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("responsavel");

                entity.Property(e => e.Senha)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ContO>(entity =>
            {
                entity.HasKey(e => e.Codi);

                entity.ToTable("ContOS", "dbo");

                entity.Property(e => e.Codi).HasColumnName("codi");

                entity.Property(e => e.CodConsult).HasMaxLength(50);

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NomConsult).HasMaxLength(100);

                entity.Property(e => e.NumOs)
                    .HasMaxLength(50)
                    .HasColumnName("NumOS");
            });

            modelBuilder.Entity<Coreme201118092012>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("coreme2011_18092012", "nape");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .HasColumnName("ANO");

                entity.Property(e => e.Bai)
                    .HasMaxLength(50)
                    .HasColumnName("bai");

                entity.Property(e => e.Cedente)
                    .HasMaxLength(32)
                    .HasColumnName("cedente");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cid)
                    .HasMaxLength(50)
                    .HasColumnName("cid");

                entity.Property(e => e.CodFap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cod_fap");

                entity.Property(e => e.Codi)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codi");

                entity.Property(e => e.Comple)
                    .HasMaxLength(15)
                    .HasColumnName("COMPLE");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("CPF");

                entity.Property(e => e.CursoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("CURSO_DESC");

                entity.Property(e => e.CursoId)
                    .HasMaxLength(5)
                    .HasColumnName("CURSO_ID");

                entity.Property(e => e.DifRm)
                    .HasMaxLength(50)
                    .HasColumnName("dif_rm");

                entity.Property(e => e.DtInscri)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INSCRI");

                entity.Property(e => e.DtVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EnderNro)
                    .HasMaxLength(5)
                    .HasColumnName("ENDER_NRO");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.FlagBoleto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_BOLETO");

                entity.Property(e => e.FlagPagto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_PAGTO");

                entity.Property(e => e.NivelDesc)
                    .HasMaxLength(50)
                    .HasColumnName("NIVEL_DESC");

                entity.Property(e => e.NivelId)
                    .HasMaxLength(3)
                    .HasColumnName("NIVEL_ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("NOME");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(8)
                    .HasColumnName("PROTOCOLO");

                entity.Property(e => e.PrsubSbaCodigo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRSUB_SBA_CODIGO");

                entity.Property(e => e.ResDdd)
                    .HasMaxLength(4)
                    .HasColumnName("RES_DDD");

                entity.Property(e => e.ResFone)
                    .HasMaxLength(4)
                    .HasColumnName("RES_FONE");

                entity.Property(e => e.ResPref)
                    .HasMaxLength(4)
                    .HasColumnName("RES_PREF");

                entity.Property(e => e.Rg)
                    .HasMaxLength(14)
                    .HasColumnName("RG");

                entity.Property(e => e.Rne)
                    .HasMaxLength(10)
                    .HasColumnName("RNE");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(30)
                    .HasColumnName("SOBRENOME");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("UF");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR");
            });

            modelBuilder.Entity<Dtproperty>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dtproperties", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lvalue)
                    .HasColumnType("image")
                    .HasColumnName("lvalue");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Property)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("property");

                entity.Property(e => e.Uvalue)
                    .HasMaxLength(255)
                    .HasColumnName("uvalue");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("value");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<EfciLogMkt>(entity =>
            {
                entity.ToTable("efci_LogMkt");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.ImgEmail)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("imgEmail");

                entity.Property(e => e.Link)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.NumEmail).HasColumnName("numEmail");
            });

            modelBuilder.Entity<EfciLogMktLido>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("efci_LogMktLidos");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmail).HasColumnName("idEmail");
            });

            modelBuilder.Entity<EfciVisita>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("efci_Visitas");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ip");
            });

            modelBuilder.Entity<Ficha>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ficha");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .HasColumnName("ANO");

                entity.Property(e => e.Bai)
                    .HasMaxLength(50)
                    .HasColumnName("bai");

                entity.Property(e => e.Cedente)
                    .HasMaxLength(32)
                    .HasColumnName("cedente");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cid)
                    .HasMaxLength(50)
                    .HasColumnName("cid");

                entity.Property(e => e.CodFap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cod_fap");

                entity.Property(e => e.Codi)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codi");

                entity.Property(e => e.Comple)
                    .HasMaxLength(15)
                    .HasColumnName("COMPLE");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("CPF");

                entity.Property(e => e.CursoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("CURSO_DESC");

                entity.Property(e => e.CursoId)
                    .HasMaxLength(5)
                    .HasColumnName("CURSO_ID");

                entity.Property(e => e.DifRm)
                    .HasMaxLength(50)
                    .HasColumnName("dif_rm");

                entity.Property(e => e.DtInscri)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INSCRI");

                entity.Property(e => e.DtVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EnderNro)
                    .HasMaxLength(5)
                    .HasColumnName("ENDER_NRO");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.FlagBoleto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_BOLETO");

                entity.Property(e => e.FlagPagto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_PAGTO");

                entity.Property(e => e.NivelDesc)
                    .HasMaxLength(50)
                    .HasColumnName("NIVEL_DESC");

                entity.Property(e => e.NivelId)
                    .HasMaxLength(3)
                    .HasColumnName("NIVEL_ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("NOME");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(8)
                    .HasColumnName("PROTOCOLO");

                entity.Property(e => e.PrsubSbaCodigo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRSUB_SBA_CODIGO");

                entity.Property(e => e.ResDdd)
                    .HasMaxLength(4)
                    .HasColumnName("RES_DDD");

                entity.Property(e => e.ResFone)
                    .HasMaxLength(4)
                    .HasColumnName("RES_FONE");

                entity.Property(e => e.ResPref)
                    .HasMaxLength(4)
                    .HasColumnName("RES_PREF");

                entity.Property(e => e.Rg)
                    .HasMaxLength(14)
                    .HasColumnName("RG");

                entity.Property(e => e.Rne)
                    .HasMaxLength(10)
                    .HasColumnName("RNE");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(30)
                    .HasColumnName("SOBRENOME");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("UF");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR");
            });

            modelBuilder.Entity<Ficha03102011>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ficha_03102011", "nape");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .HasColumnName("ANO");

                entity.Property(e => e.Bai)
                    .HasMaxLength(50)
                    .HasColumnName("bai");

                entity.Property(e => e.Cedente)
                    .HasMaxLength(32)
                    .HasColumnName("cedente");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cid)
                    .HasMaxLength(50)
                    .HasColumnName("cid");

                entity.Property(e => e.CodFap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cod_fap");

                entity.Property(e => e.Codi)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codi");

                entity.Property(e => e.Comple)
                    .HasMaxLength(15)
                    .HasColumnName("COMPLE");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("CPF");

                entity.Property(e => e.CursoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("CURSO_DESC");

                entity.Property(e => e.CursoId)
                    .HasMaxLength(5)
                    .HasColumnName("CURSO_ID");

                entity.Property(e => e.DifRm)
                    .HasMaxLength(50)
                    .HasColumnName("dif_rm");

                entity.Property(e => e.DtInscri)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INSCRI");

                entity.Property(e => e.DtVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EnderNro)
                    .HasMaxLength(5)
                    .HasColumnName("ENDER_NRO");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.FlagBoleto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_BOLETO");

                entity.Property(e => e.FlagPagto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_PAGTO");

                entity.Property(e => e.NivelDesc)
                    .HasMaxLength(50)
                    .HasColumnName("NIVEL_DESC");

                entity.Property(e => e.NivelId)
                    .HasMaxLength(3)
                    .HasColumnName("NIVEL_ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("NOME");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(8)
                    .HasColumnName("PROTOCOLO");

                entity.Property(e => e.PrsubSbaCodigo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRSUB_SBA_CODIGO");

                entity.Property(e => e.ResDdd)
                    .HasMaxLength(4)
                    .HasColumnName("RES_DDD");

                entity.Property(e => e.ResFone)
                    .HasMaxLength(4)
                    .HasColumnName("RES_FONE");

                entity.Property(e => e.ResPref)
                    .HasMaxLength(4)
                    .HasColumnName("RES_PREF");

                entity.Property(e => e.Rg)
                    .HasMaxLength(14)
                    .HasColumnName("RG");

                entity.Property(e => e.Rne)
                    .HasMaxLength(10)
                    .HasColumnName("RNE");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(30)
                    .HasColumnName("SOBRENOME");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("UF");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR");
            });

            modelBuilder.Entity<Ficha03102011New>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ficha_03102011_new", "nape");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .HasColumnName("ANO");

                entity.Property(e => e.Bai)
                    .HasMaxLength(50)
                    .HasColumnName("bai");

                entity.Property(e => e.Cedente)
                    .HasMaxLength(32)
                    .HasColumnName("cedente");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cid)
                    .HasMaxLength(50)
                    .HasColumnName("cid");

                entity.Property(e => e.CodFap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cod_fap");

                entity.Property(e => e.Codi)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codi");

                entity.Property(e => e.Comple)
                    .HasMaxLength(15)
                    .HasColumnName("COMPLE");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("CPF");

                entity.Property(e => e.CursoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("CURSO_DESC");

                entity.Property(e => e.CursoId)
                    .HasMaxLength(5)
                    .HasColumnName("CURSO_ID");

                entity.Property(e => e.DifRm)
                    .HasMaxLength(50)
                    .HasColumnName("dif_rm");

                entity.Property(e => e.DtInscri)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INSCRI");

                entity.Property(e => e.DtVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EnderNro)
                    .HasMaxLength(5)
                    .HasColumnName("ENDER_NRO");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.FlagBoleto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_BOLETO");

                entity.Property(e => e.FlagPagto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_PAGTO");

                entity.Property(e => e.NivelDesc)
                    .HasMaxLength(50)
                    .HasColumnName("NIVEL_DESC");

                entity.Property(e => e.NivelId)
                    .HasMaxLength(3)
                    .HasColumnName("NIVEL_ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("NOME");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(8)
                    .HasColumnName("PROTOCOLO");

                entity.Property(e => e.PrsubSbaCodigo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRSUB_SBA_CODIGO");

                entity.Property(e => e.ResDdd)
                    .HasMaxLength(4)
                    .HasColumnName("RES_DDD");

                entity.Property(e => e.ResFone)
                    .HasMaxLength(4)
                    .HasColumnName("RES_FONE");

                entity.Property(e => e.ResPref)
                    .HasMaxLength(4)
                    .HasColumnName("RES_PREF");

                entity.Property(e => e.Rg)
                    .HasMaxLength(14)
                    .HasColumnName("RG");

                entity.Property(e => e.Rne)
                    .HasMaxLength(10)
                    .HasColumnName("RNE");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(30)
                    .HasColumnName("SOBRENOME");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("UF");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR");
            });

            modelBuilder.Entity<Ficha14102011>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ficha_14_10_2011", "nape");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .HasColumnName("ANO");

                entity.Property(e => e.Bai)
                    .HasMaxLength(50)
                    .HasColumnName("bai");

                entity.Property(e => e.Cedente)
                    .HasMaxLength(32)
                    .HasColumnName("cedente");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cid)
                    .HasMaxLength(50)
                    .HasColumnName("cid");

                entity.Property(e => e.CodFap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cod_fap");

                entity.Property(e => e.Codi)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codi");

                entity.Property(e => e.Comple)
                    .HasMaxLength(15)
                    .HasColumnName("COMPLE");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("CPF");

                entity.Property(e => e.CursoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("CURSO_DESC");

                entity.Property(e => e.CursoId)
                    .HasMaxLength(5)
                    .HasColumnName("CURSO_ID");

                entity.Property(e => e.DifRm)
                    .HasMaxLength(50)
                    .HasColumnName("dif_rm");

                entity.Property(e => e.DtInscri)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INSCRI");

                entity.Property(e => e.DtVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EnderNro)
                    .HasMaxLength(5)
                    .HasColumnName("ENDER_NRO");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.FlagBoleto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_BOLETO");

                entity.Property(e => e.FlagPagto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_PAGTO");

                entity.Property(e => e.NivelDesc)
                    .HasMaxLength(50)
                    .HasColumnName("NIVEL_DESC");

                entity.Property(e => e.NivelId)
                    .HasMaxLength(3)
                    .HasColumnName("NIVEL_ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("NOME");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(8)
                    .HasColumnName("PROTOCOLO");

                entity.Property(e => e.PrsubSbaCodigo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRSUB_SBA_CODIGO");

                entity.Property(e => e.ResDdd)
                    .HasMaxLength(4)
                    .HasColumnName("RES_DDD");

                entity.Property(e => e.ResFone)
                    .HasMaxLength(4)
                    .HasColumnName("RES_FONE");

                entity.Property(e => e.ResPref)
                    .HasMaxLength(4)
                    .HasColumnName("RES_PREF");

                entity.Property(e => e.Rg)
                    .HasMaxLength(14)
                    .HasColumnName("RG");

                entity.Property(e => e.Rne)
                    .HasMaxLength(10)
                    .HasColumnName("RNE");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(30)
                    .HasColumnName("SOBRENOME");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("UF");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR");
            });

            modelBuilder.Entity<Ficha2012>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ficha_2012");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .HasColumnName("ANO");

                entity.Property(e => e.Bai)
                    .HasMaxLength(50)
                    .HasColumnName("bai");

                entity.Property(e => e.Cedente)
                    .HasMaxLength(32)
                    .HasColumnName("cedente");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cid)
                    .HasMaxLength(50)
                    .HasColumnName("cid");

                entity.Property(e => e.CodFap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cod_fap");

                entity.Property(e => e.Codi)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codi");

                entity.Property(e => e.Comple)
                    .HasMaxLength(15)
                    .HasColumnName("COMPLE");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("CPF");

                entity.Property(e => e.CursoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("CURSO_DESC");

                entity.Property(e => e.CursoId)
                    .HasMaxLength(5)
                    .HasColumnName("CURSO_ID");

                entity.Property(e => e.DifRm)
                    .HasMaxLength(50)
                    .HasColumnName("dif_rm");

                entity.Property(e => e.DtInscri)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INSCRI");

                entity.Property(e => e.DtVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EnderNro)
                    .HasMaxLength(5)
                    .HasColumnName("ENDER_NRO");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.FlagBoleto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_BOLETO");

                entity.Property(e => e.FlagPagto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_PAGTO");

                entity.Property(e => e.NivelDesc)
                    .HasMaxLength(50)
                    .HasColumnName("NIVEL_DESC");

                entity.Property(e => e.NivelId)
                    .HasMaxLength(3)
                    .HasColumnName("NIVEL_ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("NOME");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(8)
                    .HasColumnName("PROTOCOLO");

                entity.Property(e => e.PrsubSbaCodigo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRSUB_SBA_CODIGO");

                entity.Property(e => e.ResDdd)
                    .HasMaxLength(4)
                    .HasColumnName("RES_DDD");

                entity.Property(e => e.ResFone)
                    .HasMaxLength(4)
                    .HasColumnName("RES_FONE");

                entity.Property(e => e.ResPref)
                    .HasMaxLength(4)
                    .HasColumnName("RES_PREF");

                entity.Property(e => e.Rg)
                    .HasMaxLength(14)
                    .HasColumnName("RG");

                entity.Property(e => e.Rne)
                    .HasMaxLength(10)
                    .HasColumnName("RNE");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(30)
                    .HasColumnName("SOBRENOME");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("UF");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR");
            });

            modelBuilder.Entity<FichaAux1711>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fichaAUX1711", "dbo");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .HasColumnName("ANO");

                entity.Property(e => e.Bai)
                    .HasMaxLength(50)
                    .HasColumnName("bai");

                entity.Property(e => e.Cedente)
                    .HasMaxLength(32)
                    .HasColumnName("cedente");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cid)
                    .HasMaxLength(50)
                    .HasColumnName("cid");

                entity.Property(e => e.CodFap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cod_fap");

                entity.Property(e => e.Codi).HasColumnName("codi");

                entity.Property(e => e.Comple)
                    .HasMaxLength(15)
                    .HasColumnName("COMPLE");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("CPF");

                entity.Property(e => e.CursoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("CURSO_DESC");

                entity.Property(e => e.CursoId)
                    .HasMaxLength(5)
                    .HasColumnName("CURSO_ID");

                entity.Property(e => e.DifRm)
                    .HasMaxLength(50)
                    .HasColumnName("dif_rm");

                entity.Property(e => e.DtInscri)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INSCRI");

                entity.Property(e => e.DtVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EnderNro)
                    .HasMaxLength(5)
                    .HasColumnName("ENDER_NRO");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.FlagBoleto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_BOLETO");

                entity.Property(e => e.FlagPagto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_PAGTO");

                entity.Property(e => e.NivelDesc)
                    .HasMaxLength(50)
                    .HasColumnName("NIVEL_DESC");

                entity.Property(e => e.NivelId)
                    .HasMaxLength(3)
                    .HasColumnName("NIVEL_ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("NOME");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(8)
                    .HasColumnName("PROTOCOLO");

                entity.Property(e => e.PrsubSbaCodigo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRSUB_SBA_CODIGO");

                entity.Property(e => e.ResDdd)
                    .HasMaxLength(4)
                    .HasColumnName("RES_DDD");

                entity.Property(e => e.ResFone)
                    .HasMaxLength(4)
                    .HasColumnName("RES_FONE");

                entity.Property(e => e.ResPref)
                    .HasMaxLength(4)
                    .HasColumnName("RES_PREF");

                entity.Property(e => e.Rg)
                    .HasMaxLength(14)
                    .HasColumnName("RG");

                entity.Property(e => e.Rne)
                    .HasMaxLength(10)
                    .HasColumnName("RNE");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(30)
                    .HasColumnName("SOBRENOME");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("UF");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR");
            });

            modelBuilder.Entity<Fichacoreme>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fichacoreme");

                entity.HasIndex(e => e.Codi, "NonClusteredIndex-20161117-170528");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .HasColumnName("ANO");

                entity.Property(e => e.Bai)
                    .HasMaxLength(50)
                    .HasColumnName("bai");

                entity.Property(e => e.Cedente)
                    .HasMaxLength(32)
                    .HasColumnName("cedente");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cid)
                    .HasMaxLength(50)
                    .HasColumnName("cid");

                entity.Property(e => e.CodFap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cod_fap");

                entity.Property(e => e.Codi).HasColumnName("codi");

                entity.Property(e => e.Comple)
                    .HasMaxLength(15)
                    .HasColumnName("COMPLE");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("CPF");

                entity.Property(e => e.CursoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("CURSO_DESC");

                entity.Property(e => e.CursoId)
                    .HasMaxLength(5)
                    .HasColumnName("CURSO_ID");

                entity.Property(e => e.DifRm)
                    .HasMaxLength(50)
                    .HasColumnName("dif_rm");

                entity.Property(e => e.DtInscri)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INSCRI");

                entity.Property(e => e.DtVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EnderNro)
                    .HasMaxLength(5)
                    .HasColumnName("ENDER_NRO");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.FlagBoleto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_BOLETO");

                entity.Property(e => e.FlagPagto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_PAGTO");

                entity.Property(e => e.NivelDesc)
                    .HasMaxLength(50)
                    .HasColumnName("NIVEL_DESC");

                entity.Property(e => e.NivelId)
                    .HasMaxLength(3)
                    .HasColumnName("NIVEL_ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("NOME");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(8)
                    .HasColumnName("PROTOCOLO");

                entity.Property(e => e.PrsubSbaCodigo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRSUB_SBA_CODIGO");

                entity.Property(e => e.ResDdd)
                    .HasMaxLength(4)
                    .HasColumnName("RES_DDD");

                entity.Property(e => e.ResFone)
                    .HasMaxLength(5)
                    .HasColumnName("RES_FONE");

                entity.Property(e => e.ResPref)
                    .HasMaxLength(5)
                    .HasColumnName("RES_PREF");

                entity.Property(e => e.Rg)
                    .HasMaxLength(14)
                    .HasColumnName("RG");

                entity.Property(e => e.Rne)
                    .HasMaxLength(10)
                    .HasColumnName("RNE");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(30)
                    .HasColumnName("SOBRENOME");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("UF");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR");
            });

            modelBuilder.Entity<GerMenu>(entity =>
            {
                entity.ToTable("GER_menu", "dbo");

                entity.Property(e => e.GerMenuId).HasColumnName("GER_Menu_ID");

                entity.Property(e => e.Acesspadm).HasColumnName("acesspadm");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Inativo).HasColumnName("inativo");

                entity.Property(e => e.Ordem).HasColumnName("ordem");
            });

            modelBuilder.Entity<GerRotina>(entity =>
            {
                entity.ToTable("GER_rotina", "dbo");

                entity.Property(e => e.GerRotinaId).HasColumnName("GER_Rotina_ID");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.GerMenuId).HasColumnName("GER_Menu_ID");

                entity.Property(e => e.Icone)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("icone");

                entity.Property(e => e.Inativo).HasColumnName("inativo");

                entity.Property(e => e.Janela)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("janela");

                entity.Property(e => e.Ordem).HasColumnName("ordem");

                entity.Property(e => e.Paramauxiliar)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("paramauxiliar");

                entity.Property(e => e.Rota)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("rota");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<IntraAdmAcesso>(entity =>
            {
                entity.ToTable("INTRA_ADM_acesso");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ip");
            });

            modelBuilder.Entity<IntraAdmLogalt>(entity =>
            {
                entity.ToTable("INTRA_ADM_LOGALT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acao)
                    .HasMaxLength(640)
                    .IsUnicode(false)
                    .HasColumnName("acao");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdUser).HasColumnName("idUser");
            });

            modelBuilder.Entity<IntraAfago>(entity =>
            {
                entity.ToTable("INTRA_afagos", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Remetente)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("remetente");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Texto)
                    .HasColumnType("text")
                    .HasColumnName("texto");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.Property(e => e.Usuario).HasColumnName("usuario");
            });

            modelBuilder.Entity<IntraAgendamento>(entity =>
            {
                entity.ToTable("INTRA_Agendamento");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.DataSolicit)
                    .HasColumnType("datetime")
                    .HasColumnName("dataSolicit");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departamento");

                entity.Property(e => e.Idperiodo).HasColumnName("IDPeriodo");

                entity.Property(e => e.Idusuario).HasColumnName("IDusuario");

                entity.Property(e => e.NomeUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pessoa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pessoa");

                entity.Property(e => e.Previa)
                    .HasColumnType("text")
                    .HasColumnName("previa");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<IntraAnexoPonto>(entity =>
            {
                entity.ToTable("INTRA_AnexoPonto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("data");

                entity.Property(e => e.IdFuncionario).HasColumnName("idFuncionario");

                entity.Property(e => e.Idponto).HasColumnName("idponto");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<IntraAvaliacaoCurso>(entity =>
            {
                entity.ToTable("INTRA_avaliacaoCurso");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comentario)
                    .HasColumnType("text")
                    .HasColumnName("comentario");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCurso).HasColumnName("idCurso");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Resp1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("resp1")
                    .IsFixedLength();

                entity.Property(e => e.Resp10)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("resp10")
                    .IsFixedLength();

                entity.Property(e => e.Resp11)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("resp11")
                    .IsFixedLength();

                entity.Property(e => e.Resp12)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("resp12")
                    .IsFixedLength();

                entity.Property(e => e.Resp13)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("resp13")
                    .IsFixedLength();

                entity.Property(e => e.Resp14)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("resp14")
                    .IsFixedLength();

                entity.Property(e => e.Resp15)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("resp15")
                    .IsFixedLength();

                entity.Property(e => e.Resp2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("resp2")
                    .IsFixedLength();

                entity.Property(e => e.Resp3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("resp3")
                    .IsFixedLength();

                entity.Property(e => e.Resp4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("resp4")
                    .IsFixedLength();

                entity.Property(e => e.Resp5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("resp5")
                    .IsFixedLength();

                entity.Property(e => e.Resp6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("resp6")
                    .IsFixedLength();

                entity.Property(e => e.Resp7)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("resp7")
                    .IsFixedLength();

                entity.Property(e => e.Resp8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("resp8")
                    .IsFixedLength();

                entity.Property(e => e.Resp9)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("resp9")
                    .IsFixedLength();
            });

            modelBuilder.Entity<IntraBeneficio>(entity =>
            {
                entity.ToTable("INTRA_beneficios", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("categoria");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Foto)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.Site)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("site");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Texto)
                    .HasColumnType("text")
                    .HasColumnName("texto");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.Property(e => e.Usuario).HasColumnName("usuario");
            });

            modelBuilder.Entity<IntraBeneficiosCategorium>(entity =>
            {
                entity.ToTable("INTRA_beneficiosCategoria");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<IntraCategoriaLink>(entity =>
            {
                entity.ToTable("INTRA_categoriaLink");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nome)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<IntraCensurada>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INTRA_censuradas");

                entity.Property(e => e.Censura)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("censura");
            });

            modelBuilder.Entity<IntraCiclo>(entity =>
            {
                entity.ToTable("INTRA_ciclo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Horario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("horario");

                entity.Property(e => e.Local)
                    .HasColumnType("text")
                    .HasDefaultValueSql("('Auditório Seteco')");

                entity.Property(e => e.Observacao)
                    .HasColumnType("text")
                    .HasColumnName("observacao");

                entity.Property(e => e.Palestrante)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("palestrante");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Texto)
                    .HasColumnType("text")
                    .HasColumnName("texto");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.Property(e => e.Titulo2)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("titulo2");
            });

            modelBuilder.Entity<IntraCicloInsc>(entity =>
            {
                entity.ToTable("INTRA_cicloInsc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdCurso).HasColumnName("idCurso");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Inscrito).HasColumnName("inscrito");
            });

            modelBuilder.Entity<IntraComentario>(entity =>
            {
                entity.ToTable("INTRA_comentarios");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("comentario");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.IdConteudo).HasColumnName("idConteudo");

                entity.Property(e => e.IdFuncionario).HasColumnName("idFuncionario");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<IntraComite>(entity =>
            {
                entity.ToTable("INTRA_comites");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("cargo");

                entity.Property(e => e.Comite)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("comite");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Descricao)
                    .HasColumnType("text")
                    .HasColumnName("descricao");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.Foto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Nome)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Ordem).HasColumnName("ordem");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();
            });

            modelBuilder.Entity<IntraComunicado>(entity =>
            {
                entity.ToTable("INTRA_comunicados", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Fonte)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("fonte");

                entity.Property(e => e.Foto)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Texto)
                    .HasColumnType("text")
                    .HasColumnName("texto");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.Property(e => e.Visitas).HasColumnName("visitas");
            });

            modelBuilder.Entity<IntraConquistum>(entity =>
            {
                entity.ToTable("INTRA_conquista", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Empresa)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.Foto)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.Site)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("site");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Texto)
                    .HasColumnType("text")
                    .HasColumnName("texto");

                entity.Property(e => e.Usuario).HasColumnName("usuario");
            });

            modelBuilder.Entity<IntraConvenio>(entity =>
            {
                entity.ToTable("INTRA_convenios", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .IsFixedLength();

                entity.Property(e => e.Endereco)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.Foto)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.Nome)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Resumo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("resumo");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength();

                entity.Property(e => e.Telefone)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("telefone");

                entity.Property(e => e.Texto)
                    .HasColumnType("text")
                    .HasColumnName("texto");
            });

            modelBuilder.Entity<IntraCurso>(entity =>
            {
                entity.ToTable("INTRA_cursos", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avaliacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("avaliacao")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Carga).HasColumnName("carga");

                entity.Property(e => e.Certificado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("certificado")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Curso)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("curso");

                entity.Property(e => e.DataF)
                    .HasColumnType("datetime")
                    .HasColumnName("dataF");

                entity.Property(e => e.DataI)
                    .HasColumnType("datetime")
                    .HasColumnName("dataI");

                entity.Property(e => e.Participante).HasColumnName("participante");

                entity.Property(e => e.Pontos).HasColumnName("pontos");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("situacao");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();
            });

            modelBuilder.Entity<IntraDepartamento>(entity =>
            {
                entity.ToTable("INTRA_departamento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departamento");

                entity.Property(e => e.IdGestor)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("idGestor");
            });

            modelBuilder.Entity<IntraDepartamentoxgestor>(entity =>
            {
                entity.ToTable("INTRA_departamentoxgestor");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Departamento).HasColumnName("departamento");

                entity.Property(e => e.IdGestor).HasColumnName("idGestor");

                entity.HasOne(d => d.DepartamentoNavigation)
                    .WithMany(p => p.IntraDepartamentoxgestors)
                    .HasForeignKey(d => d.Departamento)
                    .HasConstraintName("FK__INTRA_dep__depar__3D14070F");
            });

            modelBuilder.Entity<IntraDica>(entity =>
            {
                entity.ToTable("INTRA_dicas", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Fonte)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("fonte");

                entity.Property(e => e.Foto)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Texto)
                    .HasColumnType("text")
                    .HasColumnName("texto");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.Property(e => e.Visitas).HasColumnName("visitas");
            });

            modelBuilder.Entity<IntraEmpresaExterno>(entity =>
            {
                entity.ToTable("INTRA_empresaExterno");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cod).HasColumnName("cod");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Empresa)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.HEntradaDif)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("H_entradaDif");

                entity.Property(e => e.HoraDif)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("horaDif")
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();
            });

            modelBuilder.Entity<IntraEnquete>(entity =>
            {
                entity.ToTable("INTRA_enquete");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Opcao1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("opcao1");

                entity.Property(e => e.Opcao2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("opcao2");

                entity.Property(e => e.Opcao3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("opcao3");

                entity.Property(e => e.Opcao4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("opcao4");

                entity.Property(e => e.Opcao5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("opcao5");

                entity.Property(e => e.Pergunta)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("pergunta");

                entity.Property(e => e.Resultado1)
                    .HasColumnName("resultado1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Resultado2)
                    .HasColumnName("resultado2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Resultado3)
                    .HasColumnName("resultado3")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Resultado4)
                    .HasColumnName("resultado4")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Resultado5)
                    .HasColumnName("resultado5")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tipo")
                    .IsFixedLength();

                entity.Property(e => e.Usuario).HasColumnName("usuario");
            });

            modelBuilder.Entity<IntraEnqueteLog>(entity =>
            {
                entity.ToTable("INTRA_enqueteLOG");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.IdEnquete).HasColumnName("idEnquete");

                entity.Property(e => e.Idfuncionario).HasColumnName("idfuncionario");

                entity.Property(e => e.Votado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("votado")
                    .IsFixedLength();
            });

            modelBuilder.Entity<IntraExterno>(entity =>
            {
                entity.ToTable("INTRA_externo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Atividades)
                    .HasColumnType("text")
                    .HasColumnName("atividades");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("cliente");

                entity.Property(e => e.Comentarios)
                    .HasColumnType("text")
                    .HasColumnName("comentarios");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Finalizado).HasColumnName("finalizado");

                entity.Property(e => e.HAlmoco)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("h_almoco");

                entity.Property(e => e.HEntrada)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("h_entrada");

                entity.Property(e => e.HLog)
                    .HasColumnType("datetime")
                    .HasColumnName("h_log");

                entity.Property(e => e.HRetorno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("h_retorno");

                entity.Property(e => e.HSaida)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("h_saida");

                entity.Property(e => e.IdFunc).HasColumnName("idFunc");

                entity.Property(e => e.Pendencias)
                    .HasColumnType("text")
                    .HasColumnName("pendencias");

                entity.Property(e => e.Sessao).HasColumnName("sessao");
            });

            modelBuilder.Entity<IntraFoto>(entity =>
            {
                entity.ToTable("INTRA_fotos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Foto)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.IdConteudo).HasColumnName("idConteudo");

                entity.Property(e => e.Legenda)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("legenda");

                entity.Property(e => e.Link)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<IntraFotosPqec>(entity =>
            {
                entity.ToTable("INTRA_fotosPQEC");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Foto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.IdPqec).HasColumnName("idPQEC");
            });

            modelBuilder.Entity<IntraFrase>(entity =>
            {
                entity.ToTable("INTRA_frases", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Autor)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("autor");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .IsFixedLength();

                entity.Property(e => e.Frase)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("frase");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength();
            });

            modelBuilder.Entity<IntraFuncionario>(entity =>
            {
                entity.ToTable("INTRA_funcionarios", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acesso)
                    .HasColumnType("datetime")
                    .HasColumnName("acesso");

                entity.Property(e => e.Acessolivre)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("acessolivre")
                    .IsFixedLength();

                entity.Property(e => e.Adm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("adm")
                    .IsFixedLength();

                entity.Property(e => e.Alcada).HasColumnName("alcada");

                entity.Property(e => e.Celular)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("celular");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Ctps)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ctps");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Departamento)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("departamento");

                entity.Property(e => e.DtAdmissao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAdmissao");

                entity.Property(e => e.DtAniversario)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAniversario");

                entity.Property(e => e.DtretornoFerias)
                    .HasColumnType("datetime")
                    .HasColumnName("dtretornoFerias");

                entity.Property(e => e.DtsaidaFerias)
                    .HasColumnType("datetime")
                    .HasColumnName("dtsaidaFerias");

                entity.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.Foto)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("foto")
                    .HasDefaultValueSql("('nouser.jpg')");

                entity.Property(e => e.Funcao)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("funcao");

                entity.Property(e => e.Gestor)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("gestor")
                    .IsFixedLength();

                entity.Property(e => e.Login)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("login");

                entity.Property(e => e.MsgNiver)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("msgNiver")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Nextel)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("nextel");

                entity.Property(e => e.Nome)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Registro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("registro");

                entity.Property(e => e.Senha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Telefone)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("telefone");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<IntraGestor>(entity =>
            {
                entity.ToTable("INTRA_gestor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("departamento");

                entity.Property(e => e.Idgestor).HasColumnName("idgestor");
            });

            modelBuilder.Entity<IntraJornal>(entity =>
            {
                entity.ToTable("INTRA_jornal", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Download)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("download");

                entity.Property(e => e.Foto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.Mes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mes");

                entity.Property(e => e.Pag1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pag1");

                entity.Property(e => e.Pag2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pag2");

                entity.Property(e => e.Pag3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pag3");

                entity.Property(e => e.Pag4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pag4");

                entity.Property(e => e.Pag5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pag5");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Topicos)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("topicos");

                entity.Property(e => e.Usuario).HasColumnName("usuario");
            });

            modelBuilder.Entity<IntraLeitura>(entity =>
            {
                entity.ToTable("INTRA_leitura", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Fonte)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("fonte");

                entity.Property(e => e.Foto)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Texto)
                    .HasColumnType("text")
                    .HasColumnName("texto");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.Property(e => e.Visitas)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("visitas")
                    .IsFixedLength();
            });

            modelBuilder.Entity<IntraLink>(entity =>
            {
                entity.ToTable("INTRA_links", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("categoria")
                    .IsFixedLength();

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Descricao)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Foto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.Link)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Nome)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Usuario).HasColumnName("usuario");
            });

            modelBuilder.Entity<IntraLogAcesso>(entity =>
            {
                entity.ToTable("INTRA_logAcesso");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdUser).HasColumnName("idUser");
            });

            modelBuilder.Entity<IntraLogAtualiza>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INTRA_logAtualiza");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IdOrigem).HasColumnName("id_origem");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Origem)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("origem");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<IntraLogAtualiza1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INTRA_logAtualiza", "dbo");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IdOrigem).HasColumnName("id_origem");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Origem)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("origem");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<IntraLogoFormPonto>(entity =>
            {
                entity.ToTable("INTRA_logoFormPonto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("data");

                entity.Property(e => e.Diaria)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("diaria");

                entity.Property(e => e.Horas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("horas");

                entity.Property(e => e.IdFuncionario).HasColumnName("idFuncionario");

                entity.Property(e => e.IdGestor).HasColumnName("idGestor");

                entity.Property(e => e.Just1)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("just1");

                entity.Property(e => e.Just2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("just2");

                entity.Property(e => e.Outros)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("outros");

                entity.Property(e => e.Periodo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("periodo");
            });

            modelBuilder.Entity<IntraManual>(entity =>
            {
                entity.ToTable("INTRA_manual");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Manual)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("manual");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<IntraMensagen>(entity =>
            {
                entity.ToTable("INTRA_mensagens", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Destinatario)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("destinatario");

                entity.Property(e => e.Rementente)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("rementente");

                entity.Property(e => e.Texto)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("texto");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<IntraMercado>(entity =>
            {
                entity.ToTable("INTRA_mercado", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Categoria).HasColumnName("categoria");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Descricao)
                    .HasColumnType("text")
                    .HasColumnName("descricao");

                entity.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Foto1)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("foto1");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Produto)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("produto");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Telefone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefone");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.Property(e => e.Validade)
                    .HasColumnType("datetime")
                    .HasColumnName("validade");

                entity.Property(e => e.Valor)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<IntraMercadoCategorium>(entity =>
            {
                entity.ToTable("INTRA_mercado_categoria");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("categoria");
            });

            modelBuilder.Entity<IntraNotCategorium>(entity =>
            {
                entity.ToTable("INTRA_notCategoria", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("categoria");
            });

            modelBuilder.Entity<IntraNoticia>(entity =>
            {
                entity.ToTable("INTRA_noticias", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Fonte)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("fonte");

                entity.Property(e => e.Foto)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.Html)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("html")
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Texto)
                    .HasColumnType("text")
                    .HasColumnName("texto");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.Property(e => e.Usuario).HasColumnName("usuario");

                entity.Property(e => e.Visitas).HasColumnName("visitas");
            });

            modelBuilder.Entity<IntraPermisso>(entity =>
            {
                entity.ToTable("INTRA_permissoes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.PermAfago).HasColumnName("perm_afago");

                entity.Property(e => e.PermBeneficio).HasColumnName("perm_beneficio");

                entity.Property(e => e.PermClientes).HasColumnName("perm_clientes");

                entity.Property(e => e.PermComite).HasColumnName("perm_comite");

                entity.Property(e => e.PermComunicados).HasColumnName("perm_comunicados");

                entity.Property(e => e.PermEnquete).HasColumnName("perm_enquete");

                entity.Property(e => e.PermEstudos).HasColumnName("perm_estudos");

                entity.Property(e => e.PermExterno).HasColumnName("perm_externo");

                entity.Property(e => e.PermFuncionario).HasColumnName("perm_funcionario");

                entity.Property(e => e.PermJornal).HasColumnName("perm_jornal");

                entity.Property(e => e.PermLink).HasColumnName("perm_link");

                entity.Property(e => e.PermLogAcesso).HasColumnName("perm_logAcesso");

                entity.Property(e => e.PermManual).HasColumnName("perm_manual");

                entity.Property(e => e.PermMercado).HasColumnName("perm_mercado");

                entity.Property(e => e.PermTreinamento).HasColumnName("perm_treinamento");
            });

            modelBuilder.Entity<IntraPonto>(entity =>
            {
                entity.ToTable("INTRA_Ponto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("data");

                entity.Property(e => e.DtAprovacaoNivel1)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAprovacaoNivel1");

                entity.Property(e => e.DtAprovacaoNivel2)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAprovacaoNivel2");

                entity.Property(e => e.DtAprovacaoNivel3)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAprovacaoNivel3");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Horas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("horas");

                entity.Property(e => e.IdFuncionario).HasColumnName("idFuncionario");

                entity.Property(e => e.IdGestor).HasColumnName("idGestor");

                entity.Property(e => e.Item)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("item");

                entity.Property(e => e.Justificativa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("justificativa");

                entity.Property(e => e.MotivoRecusado)
                    .IsUnicode(false)
                    .HasColumnName("motivoRecusado");

                entity.Property(e => e.Nivel1)
                    .IsUnicode(false)
                    .HasColumnName("nivel1");

                entity.Property(e => e.Nivel2)
                    .IsUnicode(false)
                    .HasColumnName("nivel2");

                entity.Property(e => e.Nivel3)
                    .IsUnicode(false)
                    .HasColumnName("nivel3");

                entity.Property(e => e.PeriodoAte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("periodo_ate");

                entity.Property(e => e.PeriodoDe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("periodo_de");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<IntraPqec>(entity =>
            {
                entity.ToTable("INTRA_pqec");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ano)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ano");

                entity.Property(e => e.Atingidos)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("atingidos");

                entity.Property(e => e.Edicao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("edicao");

                entity.Property(e => e.Empresas)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("empresas");

                entity.Property(e => e.Local)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("local");

                entity.Property(e => e.Logo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("logo");

                entity.Property(e => e.Palavra)
                    .HasColumnType("text")
                    .HasColumnName("palavra");

                entity.Property(e => e.Participantes)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("participantes");

                entity.Property(e => e.Pontos)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pontos");

                entity.Property(e => e.Selo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("selo");

                entity.Property(e => e.Show)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("show");
            });

            modelBuilder.Entity<IntraResciso>(entity =>
            {
                entity.ToTable("INTRA_rescisoes", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Empresa)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.Foto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Usuario).HasColumnName("usuario");
            });

            modelBuilder.Entity<IntraVaga>(entity =>
            {
                entity.ToTable("INTRA_vagas", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .IsFixedLength();

                entity.Property(e => e.Descricao)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength();

                entity.Property(e => e.Titulo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<IntraVideo>(entity =>
            {
                entity.ToTable("INTRA_videos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Duracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("duracao");

                entity.Property(e => e.Foto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.Texto)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("texto");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.Property(e => e.Video)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("video");
            });

            modelBuilder.Entity<Matriculaproec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("matriculaproec");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .HasColumnName("ANO");

                entity.Property(e => e.Bai)
                    .HasMaxLength(50)
                    .HasColumnName("bai");

                entity.Property(e => e.Cedente)
                    .HasMaxLength(32)
                    .HasColumnName("cedente");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cid)
                    .HasMaxLength(50)
                    .HasColumnName("cid");

                entity.Property(e => e.CodFap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cod_fap");

                entity.Property(e => e.Codi)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codi");

                entity.Property(e => e.Comple)
                    .HasMaxLength(15)
                    .HasColumnName("COMPLE");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("CPF");

                entity.Property(e => e.CursoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("CURSO_DESC");

                entity.Property(e => e.CursoId)
                    .HasMaxLength(5)
                    .HasColumnName("CURSO_ID");

                entity.Property(e => e.DifRm)
                    .HasMaxLength(50)
                    .HasColumnName("dif_rm");

                entity.Property(e => e.DtInscri)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INSCRI");

                entity.Property(e => e.DtVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EnderNro)
                    .HasMaxLength(5)
                    .HasColumnName("ENDER_NRO");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.FlagBoleto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_BOLETO");

                entity.Property(e => e.FlagPagto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_PAGTO");

                entity.Property(e => e.NivelDesc)
                    .HasMaxLength(50)
                    .HasColumnName("NIVEL_DESC");

                entity.Property(e => e.NivelId)
                    .HasMaxLength(3)
                    .HasColumnName("NIVEL_ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("NOME");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(8)
                    .HasColumnName("PROTOCOLO");

                entity.Property(e => e.PrsubSbaCodigo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRSUB_SBA_CODIGO");

                entity.Property(e => e.ResDdd)
                    .HasMaxLength(4)
                    .HasColumnName("RES_DDD");

                entity.Property(e => e.ResFone)
                    .HasMaxLength(4)
                    .HasColumnName("RES_FONE");

                entity.Property(e => e.ResPref)
                    .HasMaxLength(4)
                    .HasColumnName("RES_PREF");

                entity.Property(e => e.Rg)
                    .HasMaxLength(14)
                    .HasColumnName("RG");

                entity.Property(e => e.Rne)
                    .HasMaxLength(10)
                    .HasColumnName("RNE");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(30)
                    .HasColumnName("SOBRENOME");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("UF");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR");
            });

            modelBuilder.Entity<Nape>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nape");

                entity.Property(e => e.Ced)
                    .HasMaxLength(50)
                    .HasColumnName("ced");

                entity.Property(e => e.ClBai)
                    .HasMaxLength(50)
                    .HasColumnName("cl_bai");

                entity.Property(e => e.ClCamp4)
                    .HasMaxLength(80)
                    .HasColumnName("cl_camp4");

                entity.Property(e => e.ClCamp5)
                    .HasMaxLength(80)
                    .HasColumnName("cl_camp5");

                entity.Property(e => e.ClCep)
                    .HasMaxLength(50)
                    .HasColumnName("cl_cep");

                entity.Property(e => e.ClCgc)
                    .HasMaxLength(50)
                    .HasColumnName("cl_cgc");

                entity.Property(e => e.ClCid)
                    .HasMaxLength(50)
                    .HasColumnName("cl_cid");

                entity.Property(e => e.ClCompl)
                    .HasMaxLength(50)
                    .HasColumnName("cl_compl");

                entity.Property(e => e.ClDddC)
                    .HasMaxLength(50)
                    .HasColumnName("cl_dddC");

                entity.Property(e => e.ClDddF)
                    .HasMaxLength(50)
                    .HasColumnName("cl_dddF");

                entity.Property(e => e.ClDddR)
                    .HasMaxLength(50)
                    .HasColumnName("cl_dddR");

                entity.Property(e => e.ClEmail)
                    .HasMaxLength(50)
                    .HasColumnName("cl_email");

                entity.Property(e => e.ClEnd)
                    .HasMaxLength(50)
                    .HasColumnName("cl_end");

                entity.Property(e => e.ClEst)
                    .HasMaxLength(50)
                    .HasColumnName("cl_est");

                entity.Property(e => e.ClFax)
                    .HasMaxLength(50)
                    .HasColumnName("cl_fax");

                entity.Property(e => e.ClFonC)
                    .HasMaxLength(50)
                    .HasColumnName("cl_fonC");

                entity.Property(e => e.ClFone)
                    .HasMaxLength(50)
                    .HasColumnName("cl_fone");

                entity.Property(e => e.ClFunc)
                    .HasMaxLength(50)
                    .HasColumnName("cl_func");

                entity.Property(e => e.ClInt)
                    .HasMaxLength(50)
                    .HasColumnName("cl_int");

                entity.Property(e => e.ClNome)
                    .HasMaxLength(50)
                    .HasColumnName("cl_nome");

                entity.Property(e => e.ClNr)
                    .HasMaxLength(50)
                    .HasColumnName("cl_nr");

                entity.Property(e => e.CodFap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cod_fap ");

                entity.Property(e => e.Codi)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codi");

                entity.Property(e => e.Cso)
                    .HasMaxLength(50)
                    .HasColumnName("cso");

                entity.Property(e => e.CsoN)
                    .HasMaxLength(220)
                    .HasColumnName("csoN");

                entity.Property(e => e.CsoV)
                    .HasMaxLength(50)
                    .HasColumnName("csoV");

                entity.Property(e => e.DtInscr)
                    .HasMaxLength(50)
                    .HasColumnName("dt_inscr");

                entity.Property(e => e.DtVencto)
                    .HasMaxLength(50)
                    .HasColumnName("dt_vencto");

                entity.Property(e => e.FlagBoleto)
                    .HasMaxLength(50)
                    .HasColumnName("flag_boleto");

                entity.Property(e => e.FlagPagto)
                    .HasMaxLength(50)
                    .HasColumnName("flag_pagto");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(50)
                    .HasColumnName("protocolo");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(50)
                    .HasColumnName("situacao");
            });

            modelBuilder.Entity<ProexBkp300908>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROEX_bkp300908", "dbo");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .HasColumnName("ANO");

                entity.Property(e => e.Bai)
                    .HasMaxLength(50)
                    .HasColumnName("bai");

                entity.Property(e => e.Cedente)
                    .HasMaxLength(32)
                    .HasColumnName("cedente");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cid)
                    .HasMaxLength(50)
                    .HasColumnName("cid");

                entity.Property(e => e.CodFap)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cod_fap");

                entity.Property(e => e.Codi).HasColumnName("codi");

                entity.Property(e => e.Comple)
                    .HasMaxLength(15)
                    .HasColumnName("COMPLE");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("CPF");

                entity.Property(e => e.CursoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("CURSO_DESC");

                entity.Property(e => e.CursoId)
                    .HasMaxLength(5)
                    .HasColumnName("CURSO_ID");

                entity.Property(e => e.DifRm)
                    .HasMaxLength(50)
                    .HasColumnName("dif_rm");

                entity.Property(e => e.DtInscri)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INSCRI");

                entity.Property(e => e.DtVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EnderNro)
                    .HasMaxLength(5)
                    .HasColumnName("ENDER_NRO");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.FlagBoleto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_BOLETO");

                entity.Property(e => e.FlagPagto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_PAGTO");

                entity.Property(e => e.NivelDesc)
                    .HasMaxLength(50)
                    .HasColumnName("NIVEL_DESC");

                entity.Property(e => e.NivelId)
                    .HasMaxLength(3)
                    .HasColumnName("NIVEL_ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("NOME");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(8)
                    .HasColumnName("PROTOCOLO");

                entity.Property(e => e.PrsubSbaCodigo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRSUB_SBA_CODIGO");

                entity.Property(e => e.ResDdd)
                    .HasMaxLength(4)
                    .HasColumnName("RES_DDD");

                entity.Property(e => e.ResFone)
                    .HasMaxLength(4)
                    .HasColumnName("RES_FONE");

                entity.Property(e => e.ResPref)
                    .HasMaxLength(4)
                    .HasColumnName("RES_PREF");

                entity.Property(e => e.Rg)
                    .HasMaxLength(14)
                    .HasColumnName("RG");

                entity.Property(e => e.Rne)
                    .HasMaxLength(10)
                    .HasColumnName("RNE");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(30)
                    .HasColumnName("SOBRENOME");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("UF");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR");
            });

            modelBuilder.Entity<ProexBkpFicha>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROEX_BKP_ficha", "dbo");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .HasColumnName("ANO");

                entity.Property(e => e.Bai)
                    .HasMaxLength(50)
                    .HasColumnName("bai");

                entity.Property(e => e.Cedente)
                    .HasMaxLength(32)
                    .HasColumnName("cedente");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cid)
                    .HasMaxLength(50)
                    .HasColumnName("cid");

                entity.Property(e => e.CodFap)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cod_fap");

                entity.Property(e => e.Codi).HasColumnName("codi");

                entity.Property(e => e.Comple)
                    .HasMaxLength(15)
                    .HasColumnName("COMPLE");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("CPF");

                entity.Property(e => e.CursoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("CURSO_DESC");

                entity.Property(e => e.CursoId)
                    .HasMaxLength(5)
                    .HasColumnName("CURSO_ID");

                entity.Property(e => e.DifRm)
                    .HasMaxLength(50)
                    .HasColumnName("dif_rm");

                entity.Property(e => e.DtInscri)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INSCRI");

                entity.Property(e => e.DtVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EnderNro)
                    .HasMaxLength(5)
                    .HasColumnName("ENDER_NRO");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.FlagBoleto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_BOLETO");

                entity.Property(e => e.FlagPagto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_PAGTO");

                entity.Property(e => e.NivelDesc)
                    .HasMaxLength(50)
                    .HasColumnName("NIVEL_DESC");

                entity.Property(e => e.NivelId)
                    .HasMaxLength(3)
                    .HasColumnName("NIVEL_ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("NOME");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(8)
                    .HasColumnName("PROTOCOLO");

                entity.Property(e => e.PrsubSbaCodigo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRSUB_SBA_CODIGO");

                entity.Property(e => e.ResDdd)
                    .HasMaxLength(4)
                    .HasColumnName("RES_DDD");

                entity.Property(e => e.ResFone)
                    .HasMaxLength(4)
                    .HasColumnName("RES_FONE");

                entity.Property(e => e.ResPref)
                    .HasMaxLength(4)
                    .HasColumnName("RES_PREF");

                entity.Property(e => e.Rg)
                    .HasMaxLength(14)
                    .HasColumnName("RG");

                entity.Property(e => e.Rne)
                    .HasMaxLength(10)
                    .HasColumnName("RNE");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(30)
                    .HasColumnName("SOBRENOME");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("UF");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR");
            });

            modelBuilder.Entity<ProexCopia2911>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROEX_copia_2911", "dbo");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .HasColumnName("ANO");

                entity.Property(e => e.Cedente)
                    .HasMaxLength(32)
                    .HasColumnName("cedente");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .HasColumnName("CEP");

                entity.Property(e => e.Codi).HasColumnName("codi");

                entity.Property(e => e.Comple)
                    .HasMaxLength(15)
                    .HasColumnName("COMPLE");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("CPF");

                entity.Property(e => e.CursoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("CURSO_DESC");

                entity.Property(e => e.CursoId)
                    .HasMaxLength(5)
                    .HasColumnName("CURSO_ID");

                entity.Property(e => e.DtInscri)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INSCRI");

                entity.Property(e => e.DtVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EnderNro)
                    .HasMaxLength(5)
                    .HasColumnName("ENDER_NRO");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.FlagBoleto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_BOLETO");

                entity.Property(e => e.FlagPagto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_PAGTO");

                entity.Property(e => e.NivelDesc)
                    .HasMaxLength(50)
                    .HasColumnName("NIVEL_DESC");

                entity.Property(e => e.NivelId)
                    .HasMaxLength(3)
                    .HasColumnName("NIVEL_ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("NOME");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(8)
                    .HasColumnName("PROTOCOLO");

                entity.Property(e => e.ResDdd)
                    .HasMaxLength(4)
                    .HasColumnName("RES_DDD");

                entity.Property(e => e.ResFone)
                    .HasMaxLength(4)
                    .HasColumnName("RES_FONE");

                entity.Property(e => e.ResPref)
                    .HasMaxLength(4)
                    .HasColumnName("RES_PREF");

                entity.Property(e => e.Rg)
                    .HasMaxLength(14)
                    .HasColumnName("RG");

                entity.Property(e => e.Rne)
                    .HasMaxLength(10)
                    .HasColumnName("RNE");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(30)
                    .HasColumnName("SOBRENOME");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("UF");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR");
            });

            modelBuilder.Entity<ProexCoreme07>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROEX_coreme07", "dbo");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .HasColumnName("ANO");

                entity.Property(e => e.Bai)
                    .HasMaxLength(50)
                    .HasColumnName("bai");

                entity.Property(e => e.Cedente)
                    .HasMaxLength(32)
                    .HasColumnName("cedente");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cid)
                    .HasMaxLength(50)
                    .HasColumnName("cid");

                entity.Property(e => e.CodFap)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cod_fap");

                entity.Property(e => e.Codi).HasColumnName("codi");

                entity.Property(e => e.Comple)
                    .HasMaxLength(15)
                    .HasColumnName("COMPLE");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("CPF");

                entity.Property(e => e.CursoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("CURSO_DESC");

                entity.Property(e => e.CursoId)
                    .HasMaxLength(5)
                    .HasColumnName("CURSO_ID");

                entity.Property(e => e.DifRm)
                    .HasMaxLength(50)
                    .HasColumnName("dif_rm");

                entity.Property(e => e.DtInscri)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INSCRI");

                entity.Property(e => e.DtVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EnderNro)
                    .HasMaxLength(5)
                    .HasColumnName("ENDER_NRO");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.FlagBoleto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_BOLETO");

                entity.Property(e => e.FlagPagto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_PAGTO");

                entity.Property(e => e.NivelDesc)
                    .HasMaxLength(50)
                    .HasColumnName("NIVEL_DESC");

                entity.Property(e => e.NivelId)
                    .HasMaxLength(3)
                    .HasColumnName("NIVEL_ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("NOME");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(8)
                    .HasColumnName("PROTOCOLO");

                entity.Property(e => e.PrsubSbaCodigo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRSUB_SBA_CODIGO");

                entity.Property(e => e.ResDdd)
                    .HasMaxLength(4)
                    .HasColumnName("RES_DDD");

                entity.Property(e => e.ResFone)
                    .HasMaxLength(4)
                    .HasColumnName("RES_FONE");

                entity.Property(e => e.ResPref)
                    .HasMaxLength(4)
                    .HasColumnName("RES_PREF");

                entity.Property(e => e.Rg)
                    .HasMaxLength(14)
                    .HasColumnName("RG");

                entity.Property(e => e.Rne)
                    .HasMaxLength(10)
                    .HasColumnName("RNE");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(30)
                    .HasColumnName("SOBRENOME");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("UF");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR");
            });

            modelBuilder.Entity<ProexCoreme08>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROEX_coreme08", "dbo");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .HasColumnName("ANO");

                entity.Property(e => e.Bai)
                    .HasMaxLength(50)
                    .HasColumnName("bai");

                entity.Property(e => e.Cedente)
                    .HasMaxLength(32)
                    .HasColumnName("cedente");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cid)
                    .HasMaxLength(50)
                    .HasColumnName("cid");

                entity.Property(e => e.CodFap)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cod_fap");

                entity.Property(e => e.Codi).HasColumnName("codi");

                entity.Property(e => e.Comple)
                    .HasMaxLength(15)
                    .HasColumnName("COMPLE");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("CPF");

                entity.Property(e => e.CursoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("CURSO_DESC");

                entity.Property(e => e.CursoId)
                    .HasMaxLength(5)
                    .HasColumnName("CURSO_ID");

                entity.Property(e => e.DifRm)
                    .HasMaxLength(50)
                    .HasColumnName("dif_rm");

                entity.Property(e => e.DtInscri)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INSCRI");

                entity.Property(e => e.DtVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EnderNro)
                    .HasMaxLength(5)
                    .HasColumnName("ENDER_NRO");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.FlagBoleto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_BOLETO");

                entity.Property(e => e.FlagPagto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_PAGTO");

                entity.Property(e => e.NivelDesc)
                    .HasMaxLength(50)
                    .HasColumnName("NIVEL_DESC");

                entity.Property(e => e.NivelId)
                    .HasMaxLength(3)
                    .HasColumnName("NIVEL_ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("NOME");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(8)
                    .HasColumnName("PROTOCOLO");

                entity.Property(e => e.PrsubSbaCodigo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRSUB_SBA_CODIGO");

                entity.Property(e => e.ResDdd)
                    .HasMaxLength(4)
                    .HasColumnName("RES_DDD");

                entity.Property(e => e.ResFone)
                    .HasMaxLength(4)
                    .HasColumnName("RES_FONE");

                entity.Property(e => e.ResPref)
                    .HasMaxLength(4)
                    .HasColumnName("RES_PREF");

                entity.Property(e => e.Rg)
                    .HasMaxLength(14)
                    .HasColumnName("RG");

                entity.Property(e => e.Rne)
                    .HasMaxLength(10)
                    .HasColumnName("RNE");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(30)
                    .HasColumnName("SOBRENOME");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("UF");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR");
            });

            modelBuilder.Entity<ProexFichax>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROEX_fichax", "dbo");

                entity.Property(e => e.Ano)
                    .HasMaxLength(4)
                    .HasColumnName("ANO");

                entity.Property(e => e.Bai)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bai")
                    .IsFixedLength();

                entity.Property(e => e.Cedente)
                    .HasMaxLength(32)
                    .HasColumnName("cedente");

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cid")
                    .IsFixedLength();

                entity.Property(e => e.Codi).HasColumnName("codi");

                entity.Property(e => e.Comple)
                    .HasMaxLength(15)
                    .HasColumnName("COMPLE");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .HasColumnName("CPF");

                entity.Property(e => e.CursoDesc)
                    .HasMaxLength(100)
                    .HasColumnName("CURSO_DESC");

                entity.Property(e => e.CursoId)
                    .HasMaxLength(5)
                    .HasColumnName("CURSO_ID");

                entity.Property(e => e.DtInscri)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INSCRI");

                entity.Property(e => e.DtVencto)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_VENCTO");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EnderNro)
                    .HasMaxLength(5)
                    .HasColumnName("ENDER_NRO");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.FlagBoleto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_BOLETO");

                entity.Property(e => e.FlagPagto)
                    .HasMaxLength(1)
                    .HasColumnName("FLAG_PAGTO");

                entity.Property(e => e.NivelDesc)
                    .HasMaxLength(50)
                    .HasColumnName("NIVEL_DESC");

                entity.Property(e => e.NivelId)
                    .HasMaxLength(3)
                    .HasColumnName("NIVEL_ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("NOME");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(8)
                    .HasColumnName("PROTOCOLO");

                entity.Property(e => e.PrsubSbaCodigo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PRSUB_SBA_CODIGO");

                entity.Property(e => e.ResDdd)
                    .HasMaxLength(4)
                    .HasColumnName("RES_DDD");

                entity.Property(e => e.ResFone)
                    .HasMaxLength(4)
                    .HasColumnName("RES_FONE");

                entity.Property(e => e.ResPref)
                    .HasMaxLength(4)
                    .HasColumnName("RES_PREF");

                entity.Property(e => e.Rg)
                    .HasMaxLength(14)
                    .HasColumnName("RG");

                entity.Property(e => e.Rne)
                    .HasMaxLength(10)
                    .HasColumnName("RNE");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(30)
                    .HasColumnName("SOBRENOME");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("UF");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VALOR");
            });

            modelBuilder.Entity<Servico>(entity =>
            {
                entity.HasKey(e => e.Codi);

                entity.ToTable("servicos", "dbo");

                entity.Property(e => e.Codi).HasColumnName("CODI");

                entity.Property(e => e.ChSelect)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CodConsult)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.HoraF)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HoraI)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("horaI");

                entity.Property(e => e.Nome)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.NumOs)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NumOS");

                entity.Property(e => e.Obs)
                    .HasColumnType("text")
                    .HasColumnName("obs");

                entity.Property(e => e.Responsavel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("responsavel");
            });

            modelBuilder.Entity<Sessao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sessao");

                entity.Property(e => e.HoraFinal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hora_final");

                entity.Property(e => e.HoraInicial)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hora_inicial");

                entity.Property(e => e.IdSessao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_sessao");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ip");
            });

            modelBuilder.Entity<SysTbComunicado>(entity =>
            {
                entity.ToTable("sys_tb_comunicados", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Conteudo)
                    .HasColumnType("text")
                    .HasColumnName("conteudo");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Enviado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("enviado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Foto)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Titulo)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.Property(e => e.Veiculo)
                    .HasColumnType("text")
                    .HasColumnName("veiculo");

                entity.Property(e => e.VisitasSite)
                    .HasColumnName("visitasSite")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<SysTbComunicadosBodyMail>(entity =>
            {
                entity.ToTable("sys_tb_comunicados_BodyMail", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Corpo)
                    .HasColumnType("text")
                    .HasColumnName("corpo");

                entity.Property(e => e.Data)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Enviado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("enviado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("situacao");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.Titulo)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.Property(e => e.TotalEmail).HasColumnName("totalEmail");
            });

            modelBuilder.Entity<SysTbComunicadosLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sys_tb_comunicados_LOG", "dbo");

                entity.Property(e => e.Data)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("data");

                entity.Property(e => e.IdEmail).HasColumnName("idEmail");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Mes).HasColumnName("mes");
            });

            modelBuilder.Entity<SysTbComunicadosTemp>(entity =>
            {
                entity.ToTable("sys_tb_comunicados_temp", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Corpo)
                    .HasColumnType("text")
                    .HasColumnName("corpo");
            });

            modelBuilder.Entity<SysTbEmailComunicado>(entity =>
            {
                entity.ToTable("sys_tb_email_comunicado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Deletado)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Enviado)
                    .HasColumnName("enviado")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Nome)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<SysTbEnquete>(entity =>
            {
                entity.ToTable("sys_tb_enquete", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .IsFixedLength();

                entity.Property(e => e.Pergunta)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("pergunta");

                entity.Property(e => e.Resposta1)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("resposta1");

                entity.Property(e => e.Resposta2)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("resposta2");

                entity.Property(e => e.Resposta3)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("resposta3");

                entity.Property(e => e.Resposta4)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("resposta4");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength();

                entity.Property(e => e.Votos1).HasColumnName("votos1");

                entity.Property(e => e.Votos2).HasColumnName("votos2");

                entity.Property(e => e.Votos3).HasColumnName("votos3");

                entity.Property(e => e.Votos4).HasColumnName("votos4");
            });

            modelBuilder.Entity<SysTbLogin>(entity =>
            {
                entity.ToTable("sys_tb_login", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acesso)
                    .HasColumnType("datetime")
                    .HasColumnName("acesso");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .IsFixedLength();

                entity.Property(e => e.Departamento)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("departamento");

                entity.Property(e => e.Email)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("login");

                entity.Property(e => e.Nome)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.PermAtualizacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("perm_atualizacao")
                    .IsFixedLength();

                entity.Property(e => e.PermConsultoria)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("perm_consultoria")
                    .IsFixedLength();

                entity.Property(e => e.PermCurso)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("perm_curso")
                    .IsFixedLength();

                entity.Property(e => e.PermImporta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("perm_importa")
                    .IsFixedLength();

                entity.Property(e => e.PermPlanews)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("perm_planews")
                    .IsFixedLength();

                entity.Property(e => e.PermTreinamentos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("perm_treinamentos")
                    .IsFixedLength();

                entity.Property(e => e.PermUsuarios)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("perm_usuarios")
                    .IsFixedLength();

                entity.Property(e => e.Senha)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SysTbPermisso>(entity =>
            {
                entity.ToTable("_sys_tb_permissoes", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Permissao).HasColumnName("permissao");
            });

            modelBuilder.Entity<SysTbPermisssoesCategorium>(entity =>
            {
                entity.ToTable("sys_tb_permisssoes_categoria", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Menu)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("menu");
            });

            modelBuilder.Entity<SysTbRelatorioTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sys_tb_relatorioTemp", "dbo");

                entity.Property(e => e.Data)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("data");

                entity.Property(e => e.Email)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Nome)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<TbCadastroEmpresa>(entity =>
            {
                entity.ToTable("tb_cadastroEmpresa", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cnpj");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Contato)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contato");

                entity.Property(e => e.EmailResponsavel)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("email_responsavel");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.Fantasia)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("fantasia");

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("fax");

                entity.Property(e => e.Fone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("fone");

                entity.Property(e => e.InscEstadual)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inscEstadual");

                entity.Property(e => e.InscMunicipal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inscMunicipal");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("login");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("observacao");

                entity.Property(e => e.Responsavel)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("responsavel");

                entity.Property(e => e.Senha)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbCadastroUsuario>(entity =>
            {
                entity.ToTable("tb_cadastroUsuarios", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acesso)
                    .HasColumnType("datetime")
                    .HasColumnName("acesso");

                entity.Property(e => e.Admin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("admin")
                    .IsFixedLength();

                entity.Property(e => e.Celular)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("celular");

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codEmpresa")
                    .IsFixedLength();

                entity.Property(e => e.Deletado).HasColumnName("deletado");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("departamento");

                entity.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Enviado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("enviado")
                    .IsFixedLength();

                entity.Property(e => e.G0c554d38).HasColumnName("G_0C554D38");

                entity.Property(e => e.G98547b06).HasColumnName("G_98547B06");

                entity.Property(e => e.Login)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("login");

                entity.Property(e => e.Nome)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.NotEmail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("notEmail")
                    .IsFixedLength();

                entity.Property(e => e.NotWork)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("notWork")
                    .IsFixedLength();

                entity.Property(e => e.Observacoes)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("observacoes");

                entity.Property(e => e.OutroDp)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("outroDp");

                entity.Property(e => e.Planews).HasColumnName("planews");

                entity.Property(e => e.Ramal)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ramal");

                entity.Property(e => e.Senha)
                    .HasMaxLength(10)
                    .HasColumnName("senha")
                    .IsFixedLength();

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sexo")
                    .IsFixedLength();

                entity.Property(e => e.Sts)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sts")
                    .IsFixedLength();

                entity.Property(e => e.Telefone)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("telefone");

                entity.Property(e => e.Tempbloqueio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tempbloqueio")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Todos).HasColumnName("todos");
            });

            modelBuilder.Entity<TbCidade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cidades", "dbo");

                entity.Property(e => e.CodEstado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COD_ESTADO");

                entity.Property(e => e.DscCidade)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DSC_CIDADE");

                entity.Property(e => e.IdCidade).HasColumnName("ID_CIDADE");
            });

            modelBuilder.Entity<TbConsultoriaUser>(entity =>
            {
                entity.ToTable("tb_consultoriaUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acesso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("acesso");

                entity.Property(e => e.Adm).HasColumnName("adm");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("login");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Senha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbCurso>(entity =>
            {
                entity.ToTable("tb_cursos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Conteudo)
                    .HasColumnType("text")
                    .HasColumnName("conteudo");

                entity.Property(e => e.Gratuito)
                    .HasColumnName("gratuito")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Modulo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("modulo");

                entity.Property(e => e.Nivel)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("nivel");

                entity.Property(e => e.Sts).HasColumnName("sts");

                entity.Property(e => e.Valor)
                    .HasColumnType("money")
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<TbCursoData>(entity =>
            {
                entity.ToTable("tb_cursoDatas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.IdCurso).HasColumnName("idCurso");

                entity.Property(e => e.Limite).HasColumnName("limite");

                entity.Property(e => e.Semana)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("semana");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbCursoInsc>(entity =>
            {
                entity.ToTable("tb_cursoInsc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cursado)
                    .HasColumnName("cursado")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.IdDt).HasColumnName("idDt");

                entity.Property(e => e.IdEmp).HasColumnName("idEmp");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Nome1)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("nome1");

                entity.Property(e => e.Nome2)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("nome2");

                entity.Property(e => e.Nome3)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("nome3");

                entity.Property(e => e.Nome4)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("nome4");

                entity.Property(e => e.Nome5)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("nome5");

                entity.Property(e => e.NumInsc).HasColumnName("numInsc");

                entity.Property(e => e.Rg1)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("rg1");

                entity.Property(e => e.Rg2)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("rg2");

                entity.Property(e => e.Rg3)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("rg3");

                entity.Property(e => e.Rg4)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("rg4");

                entity.Property(e => e.Rg5)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("rg5");
            });

            modelBuilder.Entity<TbDocumentacaoCategorium>(entity =>
            {
                entity.ToTable("tb_documentacaoCategoria", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ordem)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ordem")
                    .IsFixedLength();

                entity.Property(e => e.Segmento)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("segmento");
            });

            modelBuilder.Entity<TbDocumentacaoSub>(entity =>
            {
                entity.ToTable("tb_documentacaoSub", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Arquivo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("arquivo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.IdCategoria)
                    .HasMaxLength(99)
                    .IsUnicode(false)
                    .HasColumnName("idCategoria")
                    .IsFixedLength();

                entity.Property(e => e.Ordem)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ordem")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbEnquete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_enquete", "dbo");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Pergunta)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("pergunta");

                entity.Property(e => e.Resposta1)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("resposta1");

                entity.Property(e => e.Resposta2)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("resposta2");

                entity.Property(e => e.Resposta3)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("resposta3");

                entity.Property(e => e.Resposta4)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("resposta4");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength();

                entity.Property(e => e.Votos1).HasColumnName("votos1");

                entity.Property(e => e.Votos2).HasColumnName("votos2");

                entity.Property(e => e.Votos3).HasColumnName("votos3");

                entity.Property(e => e.Votos4).HasColumnName("votos4");
            });

            modelBuilder.Entity<TbEstado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_estado", "dbo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbLayout>(entity =>
            {
                entity.ToTable("tb_layout", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Ordem)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ordem")
                    .IsFixedLength();

                entity.Property(e => e.Programa)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("programa");
            });

            modelBuilder.Entity<TbLog>(entity =>
            {
                entity.ToTable("tb_log", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Act)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("act");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            });

            modelBuilder.Entity<TbLogAnuncio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbLogAnuncio");

                entity.Property(e => e.Anuncio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("anuncio");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ip");

                entity.Property(e => e.Origem)
                    .HasColumnType("text")
                    .HasColumnName("origem");
            });

            modelBuilder.Entity<TbLogContato>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbLogContato");

                entity.Property(e => e.Anuncio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("anuncio");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmailMkt).HasColumnName("emailMkt");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.Mensagem)
                    .HasColumnType("text")
                    .HasColumnName("mensagem");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Origem)
                    .HasColumnType("text")
                    .HasColumnName("origem");
            });

            modelBuilder.Entity<TbLogEmpresa>(entity =>
            {
                entity.ToTable("tb_LogEmpresa", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Act)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("act");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("complemento");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            });

            modelBuilder.Entity<TbLogTreinamento>(entity =>
            {
                entity.ToTable("tb_logTreinamento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdEmp).HasColumnName("idEmp");

                entity.Property(e => e.IdUser).HasColumnName("idUser");
            });

            modelBuilder.Entity<TbMensagem>(entity =>
            {
                entity.ToTable("tb_mensagem", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Mensagem)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("mensagem");

                entity.Property(e => e.Ordem)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ordem")
                    .IsFixedLength();

                entity.Property(e => e.Recomendacao)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("recomendacao");
            });

            modelBuilder.Entity<TbMenuCategoriaSoluco>(entity =>
            {
                entity.ToTable("tb_menuCategoriaSolucoes", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Link)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Ordem)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ordem")
                    .IsFixedLength();

                entity.Property(e => e.Titulo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<TbMenuCategoriaSuporte>(entity =>
            {
                entity.ToTable("tb_menuCategoriaSuporte", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Link)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Ordem).HasColumnName("ordem");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<TbMenuHome>(entity =>
            {
                entity.ToTable("tb_menuHome", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Link)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Orderm).HasColumnName("orderm");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<TbMenuSoluco>(entity =>
            {
                entity.ToTable("tb_menuSolucoes", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("categoria");

                entity.Property(e => e.Conteudo)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("conteudo");

                entity.Property(e => e.Link)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Ordem)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ordem")
                    .IsFixedLength();

                entity.Property(e => e.Titulo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<TbMenuSuporte>(entity =>
            {
                entity.ToTable("tb_menuSuporte", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("categoria");

                entity.Property(e => e.Conteudo)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("conteudo");

                entity.Property(e => e.Link)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Ordem)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ordem")
                    .IsFixedLength();

                entity.Property(e => e.Sts).HasColumnName("sts");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<TbModulo>(entity =>
            {
                entity.ToTable("tb_modulo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Modulo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("modulo");
            });

            modelBuilder.Entity<TbNewsletter>(entity =>
            {
                entity.ToTable("tb_newsletter", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Sts)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sts")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbOcultaAviso>(entity =>
            {
                entity.ToTable("tb_ocultaAviso");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Iduser).HasColumnName("iduser");
            });

            modelBuilder.Entity<TbPlanewsFoto>(entity =>
            {
                entity.ToTable("tb_planewsFotos", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Foto)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.IdPlanews).HasColumnName("idPlanews");
            });

            modelBuilder.Entity<TbSistemaAtualiza>(entity =>
            {
                entity.ToTable("tb_sistemaAtualiza", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Arquivo)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("arquivo");

                entity.Property(e => e.Carta)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("carta");

                entity.Property(e => e.Conteudo)
                    .HasColumnType("text")
                    .HasColumnName("conteudo");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Email)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.NomeSis)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("nomeSis");

                entity.Property(e => e.Procedimento)
                    .HasColumnType("text")
                    .HasColumnName("procedimento");

                entity.Property(e => e.Sistema)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("sistema");

                entity.Property(e => e.Versao)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("versao");
            });

            modelBuilder.Entity<TbSoluco>(entity =>
            {
                entity.ToTable("tb_solucoes", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Solucao)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("solucao");

                entity.Property(e => e.Sts)
                    .HasMaxLength(1)
                    .HasColumnName("sts")
                    .IsFixedLength();

                entity.Property(e => e.Texto)
                    .HasColumnType("text")
                    .HasColumnName("texto");
            });

            modelBuilder.Entity<TbSolucoesFoto>(entity =>
            {
                entity.ToTable("tb_solucoesFotos", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Foto)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.IdSolucoes)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("idSolucoes")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbTempBloqueium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_tempBloqueia");

                entity.Property(e => e.Codempresa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codempresa")
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nome)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbTexto>(entity =>
            {
                entity.ToTable("tb_textos", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Home1)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("home1");

                entity.Property(e => e.Home2)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("home2");

                entity.Property(e => e.Home3)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("home3");

                entity.Property(e => e.Home4)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("home4");

                entity.Property(e => e.Link1)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("link1");

                entity.Property(e => e.Link2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("link2");

                entity.Property(e => e.Link3)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("link3");

                entity.Property(e => e.Link4)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("link4");

                entity.Property(e => e.Titulo1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("titulo1");

                entity.Property(e => e.Titulo2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("titulo2");

                entity.Property(e => e.Titulo3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("titulo3");

                entity.Property(e => e.Titulo4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("titulo4");
            });

            modelBuilder.Entity<TbTreinamento>(entity =>
            {
                entity.ToTable("tb_treinamento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acao)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("acao");

                entity.Property(e => e.Arquivo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("arquivo");

                entity.Property(e => e.Busca)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("busca");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Deletado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("deletado")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Destaque)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("destaque")
                    .HasDefaultValueSql("(0)")
                    .IsFixedLength();

                entity.Property(e => e.Duracao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("duracao");

                entity.Property(e => e.Pasta)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("pasta");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(1)")
                    .IsFixedLength();

                entity.Property(e => e.SysCtb).HasColumnName("sys_ctb");

                entity.Property(e => e.SysFin).HasColumnName("sys_fin");

                entity.Property(e => e.SysFis).HasColumnName("sys_fis");

                entity.Property(e => e.SysFol).HasColumnName("sys_fol");

                entity.Property(e => e.SysNet).HasColumnName("sys_net");

                entity.Property(e => e.SysXml).HasColumnName("sys_xml");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<TbUtilitario>(entity =>
            {
                entity.ToTable("tb_utilitarios", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Nome)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Ordem)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ordem")
                    .IsFixedLength();

                entity.Property(e => e.Programa)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("programa");
            });

            modelBuilder.Entity<Tempodecasa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Tempodecasa");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("departamento");

                entity.Property(e => e.DtAdmissao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAdmissao");

                entity.Property(e => e.Nome)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.TempoCasa).HasColumnName("Tempo_Casa");
            });

            modelBuilder.Entity<ViewGerMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewGer_Menu");

                entity.Property(e => e.Acesspadm).HasColumnName("acesspadm");

                entity.Property(e => e.DescMenu)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DescRotina)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.GerMenuId).HasColumnName("GER_Menu_ID");

                entity.Property(e => e.GerRotinaId).HasColumnName("GER_Rotina_ID");

                entity.Property(e => e.Icone)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("icone");

                entity.Property(e => e.Janela)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("janela");

                entity.Property(e => e.Paramauxiliar)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("paramauxiliar");

                entity.Property(e => e.Rota)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("rota");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<VwPontoAprovado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PONTO_Aprovados");

                entity.Property(e => e.Anexos).HasColumnName("anexos");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Data)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("data");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("departamento");

                entity.Property(e => e.DtAdmissao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAdmissao");

                entity.Property(e => e.DtAprovacaoNivel1)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAprovacaoNivel1");

                entity.Property(e => e.DtAprovacaoNivel2)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAprovacaoNivel2");

                entity.Property(e => e.DtAprovacaoNivel3)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAprovacaoNivel3");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.Horas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("horas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdFuncionario).HasColumnName("idFuncionario");

                entity.Property(e => e.IdGestor).HasColumnName("idGestor");

                entity.Property(e => e.IdPonto).HasColumnName("idPonto");

                entity.Property(e => e.Item)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("item");

                entity.Property(e => e.Justificativa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("justificativa");

                entity.Property(e => e.MotivoRecusado)
                    .IsUnicode(false)
                    .HasColumnName("motivoRecusado");

                entity.Property(e => e.Nivel1)
                    .IsUnicode(false)
                    .HasColumnName("nivel1");

                entity.Property(e => e.Nivel2)
                    .IsUnicode(false)
                    .HasColumnName("nivel2");

                entity.Property(e => e.Nivel3)
                    .IsUnicode(false)
                    .HasColumnName("nivel3");

                entity.Property(e => e.Nome)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.PeriodoAte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("periodo_ate");

                entity.Property(e => e.PeriodoDe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("periodo_de");

                entity.Property(e => e.Registro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("registro");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<VwPontoGestor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PONTO_GESTOR");

                entity.Property(e => e.Anexos).HasColumnName("anexos");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Data)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("data");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("departamento");

                entity.Property(e => e.DtAdmissao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAdmissao");

                entity.Property(e => e.DtAprovacaoNivel1)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAprovacaoNivel1");

                entity.Property(e => e.DtAprovacaoNivel2)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAprovacaoNivel2");

                entity.Property(e => e.DtAprovacaoNivel3)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAprovacaoNivel3");

                entity.Property(e => e.DtInclusao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtInclusao");

                entity.Property(e => e.Horas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("horas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdFuncionario).HasColumnName("idFuncionario");

                entity.Property(e => e.IdGestor).HasColumnName("idGestor");

                entity.Property(e => e.IdPonto).HasColumnName("idPonto");

                entity.Property(e => e.Item)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("item");

                entity.Property(e => e.Justificativa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("justificativa");

                entity.Property(e => e.MotivoRecusado)
                    .IsUnicode(false)
                    .HasColumnName("motivoRecusado");

                entity.Property(e => e.Nivel1)
                    .IsUnicode(false)
                    .HasColumnName("nivel1");

                entity.Property(e => e.Nivel2)
                    .IsUnicode(false)
                    .HasColumnName("nivel2");

                entity.Property(e => e.Nivel3)
                    .IsUnicode(false)
                    .HasColumnName("nivel3");

                entity.Property(e => e.Nome)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.PeriodoAte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("periodo_ate");

                entity.Property(e => e.PeriodoDe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("periodo_de");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
