using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIPag24horas.Model.cbolso
{
    public partial class cartaoda_bolsoContext : DbContext
    {
        public cartaoda_bolsoContext()
        {
        }

        public cartaoda_bolsoContext(DbContextOptions<cartaoda_bolsoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<AlteracoesParaBancoProducao> AlteracoesParaBancoProducao { get; set; }
        public virtual DbSet<AtividadesEconomicasP> AtividadesEconomicasP { get; set; }
        public virtual DbSet<AtividadesEconomicasPCopy> AtividadesEconomicasPCopy { get; set; }
        public virtual DbSet<Bancos> Bancos { get; set; }
        public virtual DbSet<BlacklistCnae> BlacklistCnae { get; set; }
        public virtual DbSet<Boleto> Boleto { get; set; }
        public virtual DbSet<CamposValidacao> CamposValidacao { get; set; }
        public virtual DbSet<CamposXml> CamposXml { get; set; }
        public virtual DbSet<CategoriaCliente> CategoriaCliente { get; set; }
        public virtual DbSet<CategoriaFornecedor> CategoriaFornecedor { get; set; }
        public virtual DbSet<CategoriaServicos> CategoriaServicos { get; set; }
        public virtual DbSet<Chamados> Chamados { get; set; }
        public virtual DbSet<Cidades> Cidades { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Cnaes> Cnaes { get; set; }
        public virtual DbSet<CnaesImuneTributacao> CnaesImuneTributacao { get; set; }
        public virtual DbSet<CnaesTemporal> CnaesTemporal { get; set; }
        public virtual DbSet<CombinacoesAtividades> CombinacoesAtividades { get; set; }
        public virtual DbSet<Comentarios> Comentarios { get; set; }
        public virtual DbSet<CondicaoTrabalhadorExt> CondicaoTrabalhadorExt { get; set; }
        public virtual DbSet<ConfiApp> ConfiApp { get; set; }
        public virtual DbSet<ConfigEmpresa> ConfigEmpresa { get; set; }
        public virtual DbSet<Contas> Contas { get; set; }
        public virtual DbSet<DadosAcessosn> DadosAcessosn { get; set; }
        public virtual DbSet<DadosPagamento> DadosPagamento { get; set; }
        public virtual DbSet<DasEmpresas> DasEmpresas { get; set; }
        public virtual DbSet<DependenteFuncionarios> DependenteFuncionarios { get; set; }
        public virtual DbSet<Dependentes> Dependentes { get; set; }
        public virtual DbSet<DetaEncerramento> DetaEncerramento { get; set; }
        public virtual DbSet<Duvidas> Duvidas { get; set; }
        public virtual DbSet<EmpresaEmails> EmpresaEmails { get; set; }
        public virtual DbSet<Empresapagamentos> Empresapagamentos { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<EmpresasCnae> EmpresasCnae { get; set; }
        public virtual DbSet<EmpresasDocs> EmpresasDocs { get; set; }
        public virtual DbSet<EmpresasUsuarios> EmpresasUsuarios { get; set; }
        public virtual DbSet<Encerramentos> Encerramentos { get; set; }
        public virtual DbSet<Entidades> Entidades { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<EtapaEmpresa> EtapaEmpresa { get; set; }
        public virtual DbSet<Faturamento> Faturamento { get; set; }
        public virtual DbSet<FaturamentoMensal> FaturamentoMensal { get; set; }
        public virtual DbSet<Feriados> Feriados { get; set; }
        public virtual DbSet<Ferias> Ferias { get; set; }
        public virtual DbSet<FolhaPagamento> FolhaPagamento { get; set; }
        public virtual DbSet<FolhaPagamentoConsolidada> FolhaPagamentoConsolidada { get; set; }
        public virtual DbSet<Fornecedores> Fornecedores { get; set; }
        public virtual DbSet<Franquias> Franquias { get; set; }
        public virtual DbSet<FranquiasBancos> FranquiasBancos { get; set; }
        public virtual DbSet<FranquiasClientes> FranquiasClientes { get; set; }
        public virtual DbSet<FranquiasUsuarios> FranquiasUsuarios { get; set; }
        public virtual DbSet<FuncionarioMaternidade> FuncionarioMaternidade { get; set; }
        public virtual DbSet<Funcionarios> Funcionarios { get; set; }
        public virtual DbSet<FuncionariosDependentes> FuncionariosDependentes { get; set; }
        public virtual DbSet<FuncionariosEntidades> FuncionariosEntidades { get; set; }
        public virtual DbSet<FuncionariosHorarios> FuncionariosHorarios { get; set; }
        public virtual DbSet<Funcoes> Funcoes { get; set; }
        public virtual DbSet<GrauInstitucao> GrauInstitucao { get; set; }
        public virtual DbSet<Impostos> Impostos { get; set; }
        public virtual DbSet<ImpostosBoletos> ImpostosBoletos { get; set; }
        public virtual DbSet<ImpostosEmpresas> ImpostosEmpresas { get; set; }
        public virtual DbSet<Inadimplencias> Inadimplencias { get; set; }
        public virtual DbSet<InssFolhapagamento> InssFolhapagamento { get; set; }
        public virtual DbSet<IrFolhapagamento> IrFolhapagamento { get; set; }
        public virtual DbSet<Jornada> Jornada { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<NotaFiscal> NotaFiscal { get; set; }
        public virtual DbSet<Noticias> Noticias { get; set; }
        public virtual DbSet<Pagamentos> Pagamentos { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<ParametrosGfip> ParametrosGfip { get; set; }
        public virtual DbSet<Planegamentos> Planegamentos { get; set; }
        public virtual DbSet<Plano> Plano { get; set; }
        public virtual DbSet<PlanoContaEstatico> PlanoContaEstatico { get; set; }
        public virtual DbSet<ReciboFolhaPagamento> ReciboFolhaPagamento { get; set; }
        public virtual DbSet<ReciboGps> ReciboGps { get; set; }
        public virtual DbSet<Regime> Regime { get; set; }
        public virtual DbSet<Remessas> Remessas { get; set; }
        public virtual DbSet<RescisaoFuncionario> RescisaoFuncionario { get; set; }
        public virtual DbSet<RespostasChamados> RespostasChamados { get; set; }
        public virtual DbSet<Retencoes> Retencoes { get; set; }
        public virtual DbSet<Saldos> Saldos { get; set; }
        public virtual DbSet<ServicoExtra> ServicoExtra { get; set; }
        public virtual DbSet<Socios> Socios { get; set; }
        public virtual DbSet<SociosDocs> SociosDocs { get; set; }
        public virtual DbSet<TabelaDeducaoDependente> TabelaDeducaoDependente { get; set; }
        public virtual DbSet<TabelaInss> TabelaInss { get; set; }
        public virtual DbSet<TabelaIr> TabelaIr { get; set; }
        public virtual DbSet<TabelaSalarioFamila> TabelaSalarioFamila { get; set; }
        public virtual DbSet<TabelaSalarioMinimo> TabelaSalarioMinimo { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<TipoContas> TipoContas { get; set; }
        public virtual DbSet<TipoEmpresa> TipoEmpresa { get; set; }
        public virtual DbSet<UsuariosCbolso> UsuariosCbolso { get; set; }
        public virtual DbSet<UsuariosEmpresas> UsuariosEmpresas { get; set; }
        public virtual DbSet<VerbasFuncionarios> VerbasFuncionarios { get; set; }
        public virtual DbSet<VerbasGerais> VerbasGerais { get; set; }
        public virtual DbSet<VerbasPermanentesEmpresas> VerbasPermanentesEmpresas { get; set; }
        public virtual DbSet<VerbasRescisorias> VerbasRescisorias { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=50.63.166.212;Port=3306;Database=cartaoda_bolso;Uid=cartaoda_bolso;Pwd=DAtaSUper1122;SslMode=none;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agenda>(entity =>
            {
                entity.HasKey(e => e.IdObligacao);

                entity.ToTable("agenda");

                entity.Property(e => e.IdObligacao)
                    .HasColumnName("id_obligacao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ano)
                    .HasColumnName("ano")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Dia)
                    .HasColumnName("dia")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mes)
                    .HasColumnName("mes")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Titulo)
                    .HasColumnName("titulo")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<AlteracoesParaBancoProducao>(entity =>
            {
                entity.ToTable("alteracoes_para_banco_producao");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("date");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FgAprovado)
                    .HasColumnName("fg_aprovado")
                    .HasColumnType("int(255)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FgFeito)
                    .HasColumnName("fg_feito")
                    .HasColumnType("int(255)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<AtividadesEconomicasP>(entity =>
            {
                entity.HasKey(e => e.IdOpcao);

                entity.ToTable("atividades_economicas_p");

                entity.Property(e => e.IdOpcao)
                    .HasColumnName("id_opcao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DescOpcao)
                    .IsRequired()
                    .HasColumnName("desc_opcao")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdHtml)
                    .HasColumnName("id_html")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<AtividadesEconomicasPCopy>(entity =>
            {
                entity.HasKey(e => e.IdOpcao);

                entity.ToTable("atividades_economicas_p_copy");

                entity.Property(e => e.IdOpcao)
                    .HasColumnName("id_opcao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataAtividade)
                    .HasColumnName("data_atividade")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataAtividadePrimeiroFilho)
                    .HasColumnName("data_atividade_primeiro_filho")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataGrupo)
                    .HasColumnName("data_grupo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DescOpcao)
                    .IsRequired()
                    .HasColumnName("desc_opcao")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdHtml)
                    .HasColumnName("id_html")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<Bancos>(entity =>
            {
                entity.HasKey(e => e.IdBanco);

                entity.ToTable("bancos");

                entity.Property(e => e.IdBanco)
                    .HasColumnName("id_banco")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Agencia)
                    .IsRequired()
                    .HasColumnName("agencia")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Conta)
                    .IsRequired()
                    .HasColumnName("conta")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.DataContabil)
                    .HasColumnName("data_contabil")
                    .HasColumnType("date");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdConta)
                    .HasColumnName("id_conta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSaldo)
                    .HasColumnName("id_saldo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.NumeroConta)
                    .IsRequired()
                    .HasColumnName("numero_conta")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Saldo)
                    .HasColumnName("saldo")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.SaldoPlanegado)
                    .HasColumnName("saldo_planegado")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");
            });

            modelBuilder.Entity<BlacklistCnae>(entity =>
            {
                entity.HasKey(e => e.IdCnae);

                entity.ToTable("blacklist_cnae");

                entity.Property(e => e.IdCnae)
                    .HasColumnName("id_cnae")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasColumnType("varchar(11)");

                entity.Property(e => e.Pergnta)
                    .HasColumnName("pergnta")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Texto)
                    .HasColumnName("texto")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Boleto>(entity =>
            {
                entity.ToTable("boleto");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodMovimento)
                    .HasColumnName("cod_movimento")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.DataBoleto)
                    .HasColumnName("data_boleto")
                    .HasColumnType("date");

                entity.Property(e => e.DataPagamento)
                    .HasColumnName("data_pagamento")
                    .HasColumnType("date");

                entity.Property(e => e.FgEmail)
                    .HasColumnName("fg_email")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FgGerado)
                    .HasColumnName("fg_gerado")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FgPrimeiro)
                    .HasColumnName("fg_primeiro")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFaturamento)
                    .HasColumnName("id_faturamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MesReferencia)
                    .HasColumnName("mes_referencia")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.MotivoOcorrencia)
                    .HasColumnName("motivo_ocorrencia")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.NumFuncionarios)
                    .HasColumnName("num_funcionarios")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumSocios)
                    .HasColumnName("num_socios")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Remessa)
                    .HasColumnName("remessa")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Situacao)
                    .HasColumnName("situacao")
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TipoServico)
                    .HasColumnName("tipo_servico")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorAdicional)
                    .HasColumnName("valor_adicional")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorPago)
                    .HasColumnName("valor_pago")
                    .HasColumnType("float(7,2)");
            });

            modelBuilder.Entity<CamposValidacao>(entity =>
            {
                entity.ToTable("campos_validacao");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apelido)
                    .HasColumnName("apelido")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Campo)
                    .HasColumnName("campo")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FgRequisitos)
                    .HasColumnName("fg_requisitos")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pktabela)
                    .HasColumnName("pktabela")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Tabela)
                    .HasColumnName("tabela")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Tamanho)
                    .HasColumnName("tamanho")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("int(2)");
            });

            modelBuilder.Entity<CamposXml>(entity =>
            {
                entity.ToTable("campos_xml");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Campo)
                    .HasColumnName("campo")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Codmun)
                    .HasColumnName("codmun")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ruta)
                    .HasColumnName("ruta")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<CategoriaCliente>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.ToTable("categoria_cliente");

                entity.Property(e => e.IdCategoria)
                    .HasColumnName("id_categoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Conta)
                    .IsRequired()
                    .HasColumnName("conta")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<CategoriaFornecedor>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.ToTable("categoria_fornecedor");

                entity.Property(e => e.IdCategoria)
                    .HasColumnName("id_categoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Conta)
                    .IsRequired()
                    .HasColumnName("conta")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ContaPadre)
                    .IsRequired()
                    .HasColumnName("conta_padre")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdConta)
                    .HasColumnName("id_conta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdContapadre)
                    .HasColumnName("id_contapadre")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<CategoriaServicos>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.ToTable("categoria_servicos");

                entity.Property(e => e.IdCategoria)
                    .HasColumnName("id_categoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cnae)
                    .HasColumnName("cnae")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Conta)
                    .IsRequired()
                    .HasColumnName("conta")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ContaPadre)
                    .IsRequired()
                    .HasColumnName("conta_padre")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdConta)
                    .HasColumnName("id_conta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdContapadre)
                    .HasColumnName("id_contapadre")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.OrigenCnae)
                    .HasColumnName("origen_cnae")
                    .HasColumnType("int(1)");
            });

            modelBuilder.Entity<Chamados>(entity =>
            {
                entity.HasKey(e => e.IdChamado);

                entity.ToTable("chamados");

                entity.Property(e => e.IdChamado)
                    .HasColumnName("id_chamado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Assunto)
                    .IsRequired()
                    .HasColumnName("assunto")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.DataCriacao)
                    .HasColumnName("data_criacao")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.DataUltimaMod)
                    .HasColumnName("data_ultima_mod")
                    .HasColumnType("datetime");

                entity.Property(e => e.FgComment)
                    .HasColumnName("fg_comment")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FgNovaresposta)
                    .HasColumnName("fg_novaresposta")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FgNovarespostaCbolso)
                    .HasColumnName("fg_novaresposta_cbolso")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IdArea)
                    .HasColumnName("id_area")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuarioCriador)
                    .HasColumnName("id_usuario_criador")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mensagem)
                    .HasColumnName("mensagem")
                    .HasColumnType("longtext");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Cidades>(entity =>
            {
                entity.ToTable("cidades");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasColumnName("cidade")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Codmun)
                    .HasColumnName("codmun")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SiteNfe)
                    .HasColumnName("site_nfe")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasColumnName("uf")
                    .HasColumnType("varchar(2)");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("clientes");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("id_cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Barrio)
                    .IsRequired()
                    .HasColumnName("barrio")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Calsificacao)
                    .IsRequired()
                    .HasColumnName("calsificacao")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasColumnName("cep")
                    .HasColumnType("varchar(12)");

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasColumnName("cidade")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("cnpj")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Complemento)
                    .IsRequired()
                    .HasColumnName("complemento")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Conta)
                    .IsRequired()
                    .HasColumnName("conta")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ContaOrigen)
                    .IsRequired()
                    .HasColumnName("conta_origen")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdConta)
                    .HasColumnName("id_conta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdContaorigen)
                    .HasColumnName("id_contaorigen")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Nr)
                    .IsRequired()
                    .HasColumnName("nr")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.Rua)
                    .IsRequired()
                    .HasColumnName("rua")
                    .HasColumnType("varchar(250)");
            });

            modelBuilder.Entity<Cnaes>(entity =>
            {
                entity.ToTable("cnaes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AliquotaCofins)
                    .HasColumnName("aliquota_cofins")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.AliquotaCsll)
                    .HasColumnName("aliquota_csll")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.AliquotaIrpj)
                    .HasColumnName("aliquota_irpj")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.AliquotaPis)
                    .HasColumnName("aliquota_pis")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Cnae)
                    .HasColumnName("cnae")
                    .HasColumnType("varchar(187)");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasColumnType("varchar(9)");

                entity.Property(e => e.Fap)
                    .HasColumnName("fap")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.Fpas)
                    .HasColumnName("fpas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCidade)
                    .HasColumnName("id_cidade")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PresuncaoCsll)
                    .HasColumnName("presuncao_csll")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.PresuncaoIrpj)
                    .HasColumnName("presuncao_irpj")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Rat)
                    .HasColumnName("rat")
                    .HasColumnType("int(1)");
            });

            modelBuilder.Entity<CnaesImuneTributacao>(entity =>
            {
                entity.ToTable("cnaes_imune_tributacao");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cnae)
                    .HasColumnName("cnae")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<CnaesTemporal>(entity =>
            {
                entity.ToTable("cnaes_temporal");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cnae)
                    .HasColumnName("cnae")
                    .HasColumnType("varchar(187)");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasColumnType("varchar(9)");

                entity.Property(e => e.Fap)
                    .HasColumnName("fap")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.Fpas)
                    .HasColumnName("fpas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCidade)
                    .HasColumnName("id_cidade")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rat)
                    .HasColumnName("rat")
                    .HasColumnType("int(1)");
            });

            modelBuilder.Entity<CombinacoesAtividades>(entity =>
            {
                entity.ToTable("combinacoes_atividades");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Formula)
                    .HasColumnName("formula")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.IdAtividadeP)
                    .HasColumnName("id_atividade_p")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdAtividadeS)
                    .HasColumnName("id_atividade_s")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdInput)
                    .HasColumnName("id_input")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Comentarios>(entity =>
            {
                entity.HasKey(e => e.IdComentario);

                entity.ToTable("comentarios");

                entity.Property(e => e.IdComentario)
                    .HasColumnName("id_comentario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comentario)
                    .HasColumnName("comentario")
                    .HasColumnType("text");

                entity.Property(e => e.DataComentario)
                    .HasColumnName("data_comentario")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdRequisitado)
                    .HasColumnName("id_requisitado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuariocb)
                    .HasColumnName("id_usuariocb")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Modulo)
                    .HasColumnName("modulo")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("int(2)");
            });

            modelBuilder.Entity<CondicaoTrabalhadorExt>(entity =>
            {
                entity.HasKey(e => e.IdCondicao);

                entity.ToTable("condicaoTrabalhadorExt");

                entity.Property(e => e.IdCondicao)
                    .HasColumnName("id_condicao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DesCondicao)
                    .HasColumnName("des_condicao")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ConfiApp>(entity =>
            {
                entity.HasKey(e => e.IdConf);

                entity.ToTable("confi_app");

                entity.Property(e => e.IdConf)
                    .HasColumnName("id_conf")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ConfigEmpresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("config_empresa");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DiasEmailVencimento)
                    .HasColumnName("dias_email_vencimento")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TipoImpostoIss)
                    .HasColumnName("tipo_imposto_iss")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Contas>(entity =>
            {
                entity.HasKey(e => e.IdConta);

                entity.ToTable("contas");

                entity.Property(e => e.IdConta)
                    .HasColumnName("id_conta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Conta)
                    .IsRequired()
                    .HasColumnName("conta")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdContapadre)
                    .HasColumnName("id_contapadre")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.NumContafilha)
                    .HasColumnName("num_contafilha")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("varchar(2)");
            });

            modelBuilder.Entity<DadosAcessosn>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("dados_acessosn");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Cpf)
                    .HasColumnName("cpf")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<DadosPagamento>(entity =>
            {
                entity.ToTable("dados_pagamento");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cvv)
                    .HasColumnName("cvv")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasColumnType("bigint(16)");

                entity.Property(e => e.Vencimento)
                    .HasColumnName("vencimento")
                    .HasColumnType("varchar(12)");
            });

            modelBuilder.Entity<DasEmpresas>(entity =>
            {
                entity.HasKey(e => e.IdDas);

                entity.ToTable("das_empresas");

                entity.Property(e => e.IdDas)
                    .HasColumnName("id_das")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataDas)
                    .HasColumnName("data_das")
                    .HasColumnType("date");

                entity.Property(e => e.DataEnvio)
                    .HasColumnName("data_envio")
                    .HasColumnType("date");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FgEmail)
                    .HasColumnName("fg_email")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FgGerado)
                    .HasColumnName("fg_gerado")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DependenteFuncionarios>(entity =>
            {
                entity.ToTable("dependente_funcionarios");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataNascimento)
                    .HasColumnName("data_nascimento")
                    .HasColumnType("date");

                entity.Property(e => e.IdFuncionario)
                    .HasColumnName("id_funcionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NomeDependente)
                    .HasColumnName("nome_dependente")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Parentesco)
                    .HasColumnName("parentesco")
                    .HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Dependentes>(entity =>
            {
                entity.HasKey(e => e.IdDependente);

                entity.ToTable("dependentes");

                entity.Property(e => e.IdDependente)
                    .HasColumnName("id_dependente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cartorio)
                    .IsRequired()
                    .HasColumnName("cartorio")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("cpf")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DataBaixa)
                    .HasColumnName("data_baixa")
                    .HasColumnType("date");

                entity.Property(e => e.DataEntrega)
                    .HasColumnName("data_entrega")
                    .HasColumnType("date");

                entity.Property(e => e.DataIrAte)
                    .HasColumnName("data_ir_ate")
                    .HasColumnType("date");

                entity.Property(e => e.DataNascimento)
                    .HasColumnName("data_nascimento")
                    .HasColumnType("date");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.GrauParentesco)
                    .HasColumnName("grau_parentesco")
                    .HasColumnType("int(2)");

                entity.Property(e => e.IdCidade)
                    .IsRequired()
                    .HasColumnName("id_cidade")
                    .HasColumnType("char(7)");

                entity.Property(e => e.Invalido)
                    .HasColumnName("invalido")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LocalNascimento)
                    .IsRequired()
                    .HasColumnName("local_nascimento")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Matricula)
                    .IsRequired()
                    .HasColumnName("matricula")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.NomeCidade)
                    .IsRequired()
                    .HasColumnName("nome_cidade")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NumFolha)
                    .IsRequired()
                    .HasColumnName("num_folha")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.NumLivro)
                    .IsRequired()
                    .HasColumnName("num_livro")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.NumRegistro)
                    .IsRequired()
                    .HasColumnName("num_registro")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.TipoDependencia)
                    .HasColumnName("tipo_dependencia")
                    .HasColumnType("int(2)");
            });

            modelBuilder.Entity<DetaEncerramento>(entity =>
            {
                entity.HasKey(e => e.IdDeta);

                entity.ToTable("deta_encerramento");

                entity.Property(e => e.IdDeta)
                    .HasColumnName("id_deta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Conta)
                    .IsRequired()
                    .HasColumnName("conta")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Credito)
                    .HasColumnName("credito")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Debito)
                    .HasColumnName("debito")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.IdEncerramento)
                    .HasColumnName("id_encerramento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSaldo)
                    .HasColumnName("id_saldo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Duvidas>(entity =>
            {
                entity.HasKey(e => e.IdDuvida);

                entity.ToTable("duvidas");

                entity.Property(e => e.IdDuvida)
                    .HasColumnName("id_duvida")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fase)
                    .HasColumnName("fase")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Opcao)
                    .HasColumnName("opcao")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Pergunta)
                    .HasColumnName("pergunta")
                    .HasColumnType("text");

                entity.Property(e => e.Resposta)
                    .HasColumnName("resposta")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<EmpresaEmails>(entity =>
            {
                entity.ToTable("empresa_emails");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<Empresapagamentos>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("empresapagamentos");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DiaVencimento)
                    .HasColumnName("dia_vencimento")
                    .HasColumnType("tinyint(2)");

                entity.Property(e => e.IdFaturamento)
                    .HasColumnName("id_faturamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumFuncionarios)
                    .HasColumnName("num_funcionarios")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumSocios)
                    .HasColumnName("num_socios")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tributacao)
                    .HasColumnName("tributacao")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ValorAdicional)
                    .HasColumnName("valor_adicional")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Empresas>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("empresas");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Aprovado)
                    .HasColumnName("aprovado")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Atividade)
                    .HasColumnName("atividade")
                    .HasColumnType("text");

                entity.Property(e => e.Barrio)
                    .IsRequired()
                    .HasColumnName("barrio")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasColumnName("cep")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasColumnName("cidade")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CnaeP)
                    .IsRequired()
                    .HasColumnName("cnae_p")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CnaeS)
                    .IsRequired()
                    .HasColumnName("cnae_s")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("cnpj")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Complemento)
                    .IsRequired()
                    .HasColumnName("complemento")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.DataAprovacao)
                    .HasColumnName("data_aprovacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataAssinatura)
                    .HasColumnName("data_assinatura")
                    .HasColumnType("date");

                entity.Property(e => e.DataAutomatica)
                    .HasColumnName("data_automatica")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.DataRecisao)
                    .HasColumnName("data_recisao")
                    .HasColumnType("date");

                entity.Property(e => e.DataRegistro)
                    .HasColumnName("data_registro")
                    .HasColumnType("date");

                entity.Property(e => e.DescripcaoP)
                    .IsRequired()
                    .HasColumnName("descripcao_p")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.DescripcaoS)
                    .IsRequired()
                    .HasColumnName("descripcao_s")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.DocBomb)
                    .HasColumnName("doc_bomb")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.DocContrato)
                    .HasColumnName("doc_contrato")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DocIdentidade)
                    .HasColumnName("doc_identidade")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.DocIptu)
                    .HasColumnName("doc_iptu")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FgDocssocio)
                    .HasColumnName("fg_docssocio")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FgRetencoes)
                    .HasColumnName("fg_retencoes")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FlagFuncionarios)
                    .HasColumnName("flag_funcionarios")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FlagResumo)
                    .HasColumnName("flag_resumo")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FlagSocios)
                    .HasColumnName("flag_socios")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IdCidade)
                    .HasColumnName("id_cidade")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFaturamentoMensal)
                    .HasColumnName("id_faturamento_mensal")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Inscripcao)
                    .IsRequired()
                    .HasColumnName("inscripcao")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Iptu)
                    .HasColumnName("iptu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LoginPrefeitura)
                    .HasColumnName("login_prefeitura")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.MesResponsabilidade)
                    .HasColumnName("mes_responsabilidade")
                    .HasColumnType("date");

                entity.Property(e => e.MotivoRecusa)
                    .HasColumnName("motivo_recusa")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.NaturalezaJur)
                    .IsRequired()
                    .HasColumnName("naturaleza_jur")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Nire)
                    .IsRequired()
                    .HasColumnName("nire")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.NomeFantasia)
                    .HasColumnName("nome_fantasia")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Nr)
                    .IsRequired()
                    .HasColumnName("nr")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Orgao)
                    .IsRequired()
                    .HasColumnName("orgao")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PrefeituraValidado)
                    .HasColumnName("prefeitura_validado")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QuantFuncionarios)
                    .HasColumnName("quant_funcionarios")
                    .HasColumnType("tinyint(2)");

                entity.Property(e => e.QuantSocios)
                    .HasColumnName("quant_socios")
                    .HasColumnType("tinyint(2)");

                entity.Property(e => e.RegimeCaixa)
                    .HasColumnName("regime_caixa")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Rua)
                    .IsRequired()
                    .HasColumnName("rua")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("senha")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.SenhaPrefeitura)
                    .HasColumnName("senha_prefeitura")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.TipoCadastro)
                    .HasColumnName("tipo_cadastro")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.TipoEmpresa)
                    .HasColumnName("tipo_empresa")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Tributacao)
                    .HasColumnName("tributacao")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ValidadoEmp)
                    .HasColumnName("validado_emp")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ValorCapital)
                    .HasColumnName("valor_capital")
                    .HasColumnType("float(11,2)");
            });

            modelBuilder.Entity<EmpresasCnae>(entity =>
            {
                entity.ToTable("empresas_cnae");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoServico)
                    .HasColumnName("codigo_servico")
                    .HasColumnType("char(4)");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FgPrincipal)
                    .HasColumnName("fg_principal")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<EmpresasDocs>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("empresas_docs");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Doc1)
                    .HasColumnName("doc_1")
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Doc2)
                    .HasColumnName("doc_2")
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Doc3)
                    .HasColumnName("doc_3")
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Doc4)
                    .HasColumnName("doc_4")
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<EmpresasUsuarios>(entity =>
            {
                entity.HasKey(e => e.IdLink);

                entity.ToTable("empresas_usuarios");

                entity.Property(e => e.IdLink)
                    .HasColumnName("id_link")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Encerramentos>(entity =>
            {
                entity.HasKey(e => e.IdEncerramento);

                entity.ToTable("encerramentos");

                entity.Property(e => e.IdEncerramento)
                    .HasColumnName("id_encerramento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ate)
                    .HasColumnName("ate")
                    .HasColumnType("date");

                entity.Property(e => e.Desde)
                    .HasColumnName("desde")
                    .HasColumnType("date");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Entidades>(entity =>
            {
                entity.HasKey(e => e.IdEntidad);

                entity.ToTable("entidades");

                entity.Property(e => e.IdEntidad)
                    .HasColumnName("id_entidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AgenciaGrcs)
                    .IsRequired()
                    .HasColumnName("agencia_grcs")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Apelido)
                    .IsRequired()
                    .HasColumnName("apelido")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasColumnName("bairro")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasColumnName("cep")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("cnpj")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CodCedente)
                    .IsRequired()
                    .HasColumnName("cod_cedente")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.CodEntidad)
                    .IsRequired()
                    .HasColumnName("cod_entidad")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Complemento)
                    .IsRequired()
                    .HasColumnName("complemento")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Ddd)
                    .IsRequired()
                    .HasColumnName("ddd")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasColumnName("endereco")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Entidad)
                    .IsRequired()
                    .HasColumnName("entidad")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasColumnName("fax")
                    .HasColumnType("char(9)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Fone)
                    .IsRequired()
                    .HasColumnName("fone")
                    .HasColumnType("char(9)");

                entity.Property(e => e.IdCidade)
                    .IsRequired()
                    .HasColumnName("id_cidade")
                    .HasColumnType("char(7)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Logradouro)
                    .IsRequired()
                    .HasColumnName("logradouro")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.NomeCidade)
                    .IsRequired()
                    .HasColumnName("nome_cidade")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NomeEntidad)
                    .IsRequired()
                    .HasColumnName("nome_entidad")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasColumnName("site")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.TipoEntidad)
                    .IsRequired()
                    .HasColumnName("tipo_entidad")
                    .HasColumnType("char(1)");
            });

            modelBuilder.Entity<EstadoCivil>(entity =>
            {
                entity.ToTable("estado_civil");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.EstadoDesc)
                    .HasColumnName("estado_desc")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Estados>(entity =>
            {
                entity.HasKey(e => e.CodEstado);

                entity.ToTable("estados");

                entity.Property(e => e.CodEstado)
                    .HasColumnName("cod_estado")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.NomEstado)
                    .IsRequired()
                    .HasColumnName("nom_estado")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SglEstado)
                    .IsRequired()
                    .HasColumnName("sgl_estado")
                    .HasColumnType("char(2)");
            });

            modelBuilder.Entity<EtapaEmpresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("etapa_empresa");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Etapa)
                    .HasColumnName("etapa")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Passo)
                    .HasColumnName("passo")
                    .HasColumnType("int(2)");
            });

            modelBuilder.Entity<Faturamento>(entity =>
            {
                entity.HasKey(e => e.IdFaturamento);

                entity.ToTable("faturamento");

                entity.Property(e => e.IdFaturamento)
                    .HasColumnName("id_faturamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValorBase1)
                    .HasColumnName("valor_base1")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.ValorBase2)
                    .HasColumnName("valor_base2")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.ValorFaixa)
                    .HasColumnName("valor_faixa")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<FaturamentoMensal>(entity =>
            {
                entity.ToTable("faturamento_mensal");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Faturamento)
                    .HasColumnName("faturamento")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Feriados>(entity =>
            {
                entity.HasKey(e => e.IdFeriado);

                entity.ToTable("feriados");

                entity.Property(e => e.IdFeriado)
                    .HasColumnName("id_feriado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ano)
                    .HasColumnName("ano")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.DescFeriado)
                    .HasColumnName("desc_feriado")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Dia)
                    .HasColumnName("dia")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Mes)
                    .HasColumnName("mes")
                    .HasColumnType("varchar(3)");
            });

            modelBuilder.Entity<Ferias>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("ferias");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FimFerias)
                    .HasColumnName("fim_ferias")
                    .HasColumnType("date");

                entity.Property(e => e.IdFuncionario)
                    .HasColumnName("id_funcionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InicFerias)
                    .HasColumnName("inic_ferias")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<FolhaPagamento>(entity =>
            {
                entity.ToTable("folha_pagamento");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFuncionario)
                    .HasColumnName("id_funcionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdVerba)
                    .HasColumnName("id_verba")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mes)
                    .HasColumnName("mes")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Referencia).HasColumnName("referencia");

                entity.Property(e => e.Valor).HasColumnName("valor");
            });

            modelBuilder.Entity<FolhaPagamentoConsolidada>(entity =>
            {
                entity.ToTable("folha_pagamento_consolidada");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BaseFgts).HasColumnName("base_fgts");

                entity.Property(e => e.BaseInss).HasColumnName("base_inss");

                entity.Property(e => e.BaseIrpf).HasColumnName("base_irpf");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFuncionario)
                    .HasColumnName("id_funcionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mes)
                    .HasColumnName("mes")
                    .HasColumnType("int(2)");

                entity.Property(e => e.ValorFgts).HasColumnName("valor_fgts");

                entity.Property(e => e.ValorInss).HasColumnName("valor_inss");

                entity.Property(e => e.ValorIrpf).HasColumnName("valor_irpf");

                entity.Property(e => e.ValorLiquido).HasColumnName("valor_liquido");
            });

            modelBuilder.Entity<Fornecedores>(entity =>
            {
                entity.HasKey(e => e.IdFornecedor);

                entity.ToTable("fornecedores");

                entity.Property(e => e.IdFornecedor)
                    .HasColumnName("id_fornecedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("cnpj")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Conta)
                    .IsRequired()
                    .HasColumnName("conta")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ContaOrigen)
                    .IsRequired()
                    .HasColumnName("conta_origen")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Contato)
                    .HasColumnName("contato")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Historico)
                    .HasColumnName("historico")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.IdCategoria)
                    .HasColumnName("id_categoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdConta)
                    .HasColumnName("id_conta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdContaorigen)
                    .HasColumnName("id_contaorigen")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasColumnType("varchar(80)");
            });

            modelBuilder.Entity<Franquias>(entity =>
            {
                entity.ToTable("franquias");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Cidade)
                    .HasColumnName("cidade")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.NomeResponsavel)
                    .HasColumnName("nome_responsavel")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RazaoSocial)
                    .HasColumnName("razao_social")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Uf)
                    .HasColumnName("uf")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<FranquiasBancos>(entity =>
            {
                entity.ToTable("franquias_bancos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Agencia)
                    .HasColumnName("agencia")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoBanco)
                    .HasColumnName("codigo_banco")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Conta)
                    .HasColumnName("conta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Convenio)
                    .HasColumnName("convenio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFranquia)
                    .HasColumnName("id_franquia")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NomeBanco)
                    .HasColumnName("nome_banco")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<FranquiasClientes>(entity =>
            {
                entity.ToTable("franquias_clientes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFranquia)
                    .HasColumnName("id_franquia")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NomeCliente)
                    .HasColumnName("nome_cliente")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<FranquiasUsuarios>(entity =>
            {
                entity.ToTable("franquias_usuarios");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFranquia)
                    .HasColumnName("id_franquia")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<FuncionarioMaternidade>(entity =>
            {
                entity.ToTable("funcionario_maternidade");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataFin)
                    .HasColumnName("data_fin")
                    .HasColumnType("date");

                entity.Property(e => e.DataIni)
                    .HasColumnName("data_ini")
                    .HasColumnType("date");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFuncionario)
                    .HasColumnName("id_funcionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");
            });

            modelBuilder.Entity<Funcionarios>(entity =>
            {
                entity.HasKey(e => e.id_funcionario);

                entity.ToTable("funcionarios");

                entity.Property(e => e.id_funcionario)
                    .HasColumnName("id_funcionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.admissao)
                    .HasColumnName("admissao")
                    .HasColumnType("date");

                entity.Property(e => e.altura)
                    .HasColumnName("altura")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.barrio)
                    .IsRequired()
                    .HasColumnName("barrio")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.cadastro)
                    .HasColumnName("cadastro")
                    .HasColumnType("date");

                entity.Property(e => e.cargo)
                    .HasColumnName("cargo")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.carteira)
                    .HasColumnName("carteira")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.categoria_cnh)
                    .IsRequired()
                    .HasColumnName("categoria_cnh")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.celular)
                    .IsRequired()
                    .HasColumnName("celular")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.cep)
                    .HasColumnName("cep")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.cidade)
                    .IsRequired()
                    .HasColumnName("cidade")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.cidade_nasc)
                    .IsRequired()
                    .HasColumnName("cidade_nasc")
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.cnh)
                    .IsRequired()
                    .HasColumnName("cnh")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.complemento)
                    .IsRequired()
                    .HasColumnName("complemento")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.conta)
                    .IsRequired()
                    .HasColumnName("conta")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.cor_cabelo)
                    .IsRequired()
                    .HasColumnName("cor_cabelo")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.cor_olhos)
                    .IsRequired()
                    .HasColumnName("cor_olhos")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.cpf)
                    .IsRequired()
                    .HasColumnName("cpf")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.data_aposentadoria)
                    .HasColumnName("data_aposentadoria")
                    .HasColumnType("date");

                entity.Property(e => e.data_aviso)
                    .HasColumnName("data_aviso")
                    .HasColumnType("date");

                entity.Property(e => e.data_cadastro)
                    .HasColumnName("data_cadastro")
                    .HasColumnType("date");

                entity.Property(e => e.data_chegada)
                    .HasColumnName("data_chegada")
                    .HasColumnType("date");

                entity.Property(e => e.data_demissao)
                    .HasColumnName("data_demissao")
                    .HasColumnType("date");

                entity.Property(e => e.data_emissao_carteira)
                    .HasColumnName("data_emissao_carteira")
                    .HasColumnType("date");

                entity.Property(e => e.data_emissao_pis)
                    .HasColumnName("data_emissao_pis")
                    .HasColumnType("date");

                entity.Property(e => e.data_emissao_rg)
                    .HasColumnName("data_emissao_rg")
                    .HasColumnType("date");

                entity.Property(e => e.data_inicio)
                    .HasColumnName("data_inicio")
                    .HasColumnType("date");

                entity.Property(e => e.data_nascimento)
                    .HasColumnName("data_nascimento")
                    .HasColumnType("date");

                entity.Property(e => e.deficiencia)
                    .IsRequired()
                    .HasColumnName("deficiencia")
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.dependente)
                    .HasColumnName("dependente")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.digito)
                    .HasColumnName("digito")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.estado_civil)
                    .HasColumnName("estado_civil")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.estado_nasc)
                    .IsRequired()
                    .HasColumnName("estado_nasc")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.fg_aposentadoria)
                    .HasColumnName("fg_aposentadoria")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.fg_ativo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.fg_casado_ext)
                    .HasColumnName("fg_casado_ext")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.fg_filhos_ext)
                    .HasColumnName("fg_filhos_ext")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.fg_primero_emprego)
                    .HasColumnName("fg_primero_emprego")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.fin_prazo)
                    .HasColumnName("fin_prazo")
                    .HasColumnType("date");

                entity.Property(e => e.fin_prorrogacao)
                    .HasColumnName("fin_prorrogacao")
                    .HasColumnType("date");

                entity.Property(e => e.grau_inst)
                    .HasColumnName("grau_inst")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.horas)
                    .HasColumnName("horas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.id_cidade)
                    .HasColumnName("id_cidade")
                    .HasColumnType("int(11)");

                entity.Property(e => e.idCidade_nascimento)
                    .HasColumnName("idCidade_nascimento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.id_condicao_ext)
                    .HasColumnName("id_condicao_ext")
                    .HasColumnType("int(11)");

                entity.Property(e => e.id_conta)
                    .HasColumnName("id_conta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.id_contrato)
                    .HasColumnName("id_contrato")
                    .HasColumnType("int(11)");

                entity.Property(e => e.id_empresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.id_estado)
                    .HasColumnName("id_estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.id_funcao)
                    .HasColumnName("id_funcao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.idPais_nacionalidade)
                    .HasColumnName("idPais_nacionalidade")
                    .HasColumnType("int(11)");

                entity.Property(e => e.idPais_nascimento)
                    .HasColumnName("idPais_nascimento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.id_usuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.insalubridade)
                    .HasColumnName("insalubridade")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.insalubridade_i)
                    .IsRequired()
                    .HasColumnName("insalubridade_i")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.motivo_recusa)
                    .HasColumnName("motivo_recusa")
                    .HasColumnType("text");

                entity.Property(e => e.nacionalidade)
                    .IsRequired()
                    .HasColumnName("nacionalidade")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.natureza_ocupacao)
                    .IsRequired()
                    .HasColumnName("natureza_ocupacao")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.nis)
                    .HasColumnName("nis")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.nome_conjuge)
                    .IsRequired()
                    .HasColumnName("nome_conjuge")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.nome_mae)
                    .HasColumnName("nome_mae")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.nome_pai)
                    .HasColumnName("nome_pai")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.noturno)
                    .HasColumnName("noturno")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.noturno_i)
                    .IsRequired()
                    .HasColumnName("noturno_i")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.nr)
                    .HasColumnName("nr")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.orgao_rg)
                    .IsRequired()
                    .HasColumnName("orgao_rg")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.periculosidade)
                    .HasColumnName("periculosidade")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.periculosidade_i)
                    .IsRequired()
                    .HasColumnName("periculosidade_i")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.peso)
                    .HasColumnName("peso")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.pis)
                    .IsRequired()
                    .HasColumnName("pis")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.prazo_exp)
                    .HasColumnName("prazo_exp")
                    .HasColumnType("int(11)");

                entity.Property(e => e.prorrogacao)
                    .HasColumnName("prorrogacao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.raca)
                    .IsRequired()
                    .HasColumnName("raca")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.rg)
                    .HasColumnName("rg")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.rua)
                    .HasColumnName("rua")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.salario)
                    .HasColumnName("salario")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.serie)
                    .HasColumnName("serie")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.sexo)
                    .IsRequired()
                    .HasColumnName("sexo")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.telefone)
                    .IsRequired()
                    .HasColumnName("telefone")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.tipo_admissao)
                    .IsRequired()
                    .HasColumnName("tipo_admissao")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.tipo_horario_trabalho)
                    .HasColumnName("tipo_horario_trabalho")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.tipo_sanguineo)
                    .IsRequired()
                    .HasColumnName("tipo_sanguineo")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.uf_carteira)
                    .IsRequired()
                    .HasColumnName("uf_carteira")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.uf_rg)
                    .HasColumnName("uf_rg")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.validado)
                    .HasColumnName("validado")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<FuncionariosDependentes>(entity =>
            {
                entity.HasKey(e => e.IdLink);

                entity.ToTable("funcionarios_dependentes");

                entity.Property(e => e.IdLink)
                    .HasColumnName("id_link")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdDependente)
                    .HasColumnName("id_dependente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFuncionario)
                    .HasColumnName("id_funcionario")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<FuncionariosEntidades>(entity =>
            {
                entity.HasKey(e => e.IdLink);

                entity.ToTable("funcionarios_entidades");

                entity.Property(e => e.IdLink)
                    .HasColumnName("id_link")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEntidad)
                    .HasColumnName("id_entidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFuncionario)
                    .HasColumnName("id_funcionario")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<FuncionariosHorarios>(entity =>
            {
                entity.ToTable("funcionarios_horarios");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlmocoFin)
                    .HasColumnName("almoco_fin")
                    .HasColumnType("time");

                entity.Property(e => e.AlmocoIni)
                    .HasColumnName("almoco_ini")
                    .HasColumnType("time");

                entity.Property(e => e.DiaSemana)
                    .HasColumnName("dia_semana")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Entrada)
                    .HasColumnName("entrada")
                    .HasColumnType("time");

                entity.Property(e => e.IdFuncionario)
                    .HasColumnName("id_funcionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Saida)
                    .HasColumnName("saida")
                    .HasColumnType("time");
            });

            modelBuilder.Entity<Funcoes>(entity =>
            {
                entity.HasKey(e => e.IdFuncao);

                entity.ToTable("funcoes");

                entity.Property(e => e.IdFuncao)
                    .HasColumnName("id_funcao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cbo)
                    .IsRequired()
                    .HasColumnName("cbo")
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.CodigoCbo)
                    .IsRequired()
                    .HasColumnName("codigo_cbo")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.DescFuncao)
                    .IsRequired()
                    .HasColumnName("desc_funcao")
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdFuncionario)
                    .HasColumnName("id_funcionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumFuncao)
                    .HasColumnName("num_funcao")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GrauInstitucao>(entity =>
            {
                entity.HasKey(e => e.IdGrau);

                entity.ToTable("grau_institucao");

                entity.Property(e => e.IdGrau)
                    .HasColumnName("id_grau")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoGrau)
                    .HasColumnName("codigo_grau")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.DescGrau)
                    .HasColumnName("desc_grau")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Impostos>(entity =>
            {
                entity.HasKey(e => e.IdImposto);

                entity.ToTable("impostos");

                entity.Property(e => e.IdImposto)
                    .HasColumnName("id_imposto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoReceita)
                    .HasColumnName("codigo_receita")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Conta)
                    .IsRequired()
                    .HasColumnName("conta")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ContaOrigen)
                    .IsRequired()
                    .HasColumnName("conta_origen")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ContaReter)
                    .IsRequired()
                    .HasColumnName("conta_reter")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ContaTotalizadora)
                    .IsRequired()
                    .HasColumnName("conta_totalizadora")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FgReter)
                    .HasColumnName("fg_reter")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IdConta)
                    .HasColumnName("id_conta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdContaorigen)
                    .HasColumnName("id_contaorigen")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdContapadre)
                    .HasColumnName("id_contapadre")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdContareter)
                    .HasColumnName("id_contareter")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdContatotalizadora)
                    .HasColumnName("id_contatotalizadora")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("int(1)");

                entity.Property(e => e.TipoTributacao)
                    .HasColumnName("tipo_tributacao")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Uso)
                    .IsRequired()
                    .HasColumnName("uso")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<ImpostosBoletos>(entity =>
            {
                entity.HasKey(e => e.IdBoleto);

                entity.ToTable("impostos_boletos");

                entity.Property(e => e.IdBoleto)
                    .HasColumnName("id_boleto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BaseCalculo)
                    .HasColumnName("base_calculo")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.DataApuracao)
                    .HasColumnName("data_apuracao")
                    .HasColumnType("date");

                entity.Property(e => e.DataMa)
                    .HasColumnName("dataMA")
                    .HasColumnType("char(7)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FgPago)
                    .HasColumnName("fg_pago")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPlanegamento)
                    .HasColumnName("id_planegamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoImposto)
                    .HasColumnName("tipo_imposto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorFaturamento)
                    .HasColumnName("valor_faturamento")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<ImpostosEmpresas>(entity =>
            {
                entity.HasKey(e => e.IdLink);

                entity.ToTable("impostos_empresas");

                entity.Property(e => e.IdLink)
                    .HasColumnName("id_link")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdConta)
                    .HasColumnName("id_conta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdImposto)
                    .HasColumnName("id_imposto")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Inadimplencias>(entity =>
            {
                entity.HasKey(e => e.IdInadimplencia);

                entity.ToTable("inadimplencias");

                entity.Property(e => e.IdInadimplencia)
                    .HasColumnName("id_inadimplencia")
                    .HasColumnType("int(1)");

                entity.Property(e => e.DataConfianca)
                    .HasColumnName("data_confianca")
                    .HasColumnType("date");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FgVotoconfianca)
                    .HasColumnName("fg_votoconfianca")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("int(1)");
            });

            modelBuilder.Entity<InssFolhapagamento>(entity =>
            {
                entity.ToTable("inss_folhapagamento");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Percentual)
                    .HasColumnName("percentual")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorMax)
                    .HasColumnName("valor_max")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorMin)
                    .HasColumnName("valor_min")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<IrFolhapagamento>(entity =>
            {
                entity.ToTable("ir_folhapagamento");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParcelaDeduzir)
                    .HasColumnName("parcela_deduzir")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Percentual)
                    .HasColumnName("percentual")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorMax)
                    .HasColumnName("valor_max")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorMin)
                    .HasColumnName("valor_min")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Jornada>(entity =>
            {
                entity.HasKey(e => e.IdJornada);

                entity.ToTable("jornada");

                entity.Property(e => e.IdJornada)
                    .HasColumnName("id_jornada")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ate)
                    .IsRequired()
                    .HasColumnName("ate")
                    .HasColumnType("varchar(6)");

                entity.Property(e => e.Descanso)
                    .IsRequired()
                    .HasColumnName("descanso")
                    .HasColumnType("varchar(6)");

                entity.Property(e => e.Desde)
                    .IsRequired()
                    .HasColumnName("desde")
                    .HasColumnType("varchar(6)");

                entity.Property(e => e.Dia)
                    .IsRequired()
                    .HasColumnName("dia")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdFuncionario)
                    .HasColumnName("id_funcionario")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Municipios>(entity =>
            {
                entity.HasKey(e => e.CodigoMun);

                entity.ToTable("municipios");

                entity.Property(e => e.CodigoMun)
                    .HasColumnName("codigo_mun")
                    .HasColumnType("char(8)");

                entity.Property(e => e.EstadoMun)
                    .IsRequired()
                    .HasColumnName("estado_mun")
                    .HasColumnType("char(2)");

                entity.Property(e => e.NomeMun)
                    .IsRequired()
                    .HasColumnName("nome_mun")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<NotaFiscal>(entity =>
            {
                entity.HasKey(e => e.IdNota);

                entity.ToTable("nota_fiscal");

                entity.Property(e => e.IdNota)
                    .HasColumnName("id_nota")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Aliquota)
                    .HasColumnName("aliquota")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Cnae)
                    .HasColumnName("cnae")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CodigoServico)
                    .HasColumnName("codigo_servico")
                    .HasColumnType("char(5)");

                entity.Property(e => e.Codver)
                    .HasColumnName("codver")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Competencia)
                    .HasColumnName("competencia")
                    .HasColumnType("date");

                entity.Property(e => e.DataEmissao)
                    .HasColumnName("data_emissao")
                    .HasColumnType("date");

                entity.Property(e => e.DataPagamento)
                    .HasColumnName("data_pagamento")
                    .HasColumnType("date");

                entity.Property(e => e.DescontoCondicionado)
                    .HasColumnName("desconto_condicionado")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Discriminacao)
                    .HasColumnName("discriminacao")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FgCancelado)
                    .HasColumnName("fg_cancelado")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FgExigibilidade)
                    .HasColumnName("fg_exigibilidade")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.FgImportado)
                    .HasColumnName("fg_importado")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FgIssretido)
                    .HasColumnName("fg_issretido")
                    .HasColumnType("int(1)");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("id_cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OutrasReten)
                    .HasColumnName("outras_reten")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorCofins)
                    .HasColumnName("valor_cofins")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorCredito)
                    .HasColumnName("valor_credito")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorCsll)
                    .HasColumnName("valor_csll")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorDeducoes)
                    .HasColumnName("valor_deducoes")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorInss)
                    .HasColumnName("valor_inss")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorIr)
                    .HasColumnName("valor_ir")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorIss)
                    .HasColumnName("valor_iss")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorPis)
                    .HasColumnName("valor_pis")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorServicos)
                    .HasColumnName("valor_servicos")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Noticias>(entity =>
            {
                entity.HasKey(e => e.IdNoticia);

                entity.ToTable("noticias");

                entity.Property(e => e.IdNoticia)
                    .HasColumnName("id_noticia")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataPublicacao)
                    .HasColumnName("data_publicacao")
                    .HasColumnType("date");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Texto)
                    .HasColumnName("texto")
                    .HasColumnType("text");

                entity.Property(e => e.Titulo)
                    .HasColumnName("titulo")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Views)
                    .HasColumnName("views")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Pagamentos>(entity =>
            {
                entity.HasKey(e => e.IdPagamento);

                entity.ToTable("pagamentos");

                entity.Property(e => e.IdPagamento)
                    .HasColumnName("id_pagamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("date");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FimPeriodo)
                    .HasColumnName("fim_periodo")
                    .HasColumnType("date");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InicioPeriodo)
                    .HasColumnName("inicio_periodo")
                    .HasColumnType("date");

                entity.Property(e => e.Plano)
                    .IsRequired()
                    .HasColumnName("plano")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.Referencia)
                    .HasColumnName("referencia")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.HasKey(e => e.IdPais);

                entity.ToTable("paises");

                entity.Property(e => e.IdPais)
                    .HasColumnName("id_pais")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CiudadanoDes)
                    .HasColumnName("ciudadano_des")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CodigoPais)
                    .HasColumnName("codigo_pais")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<ParametrosGfip>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("parametros_gfip");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodCompetencia)
                    .HasColumnName("cod_competencia")
                    .HasColumnType("int(3)");
            });

            modelBuilder.Entity<Planegamentos>(entity =>
            {
                entity.HasKey(e => e.IdPlanegamento);

                entity.ToTable("planegamentos");

                entity.Property(e => e.IdPlanegamento)
                    .HasColumnName("id_planegamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Conta)
                    .IsRequired()
                    .HasColumnName("conta")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("date");

                entity.Property(e => e.DataBaixa)
                    .HasColumnName("data_baixa")
                    .HasColumnType("date");

                entity.Property(e => e.DataReferencia)
                    .HasColumnName("data_referencia")
                    .HasColumnType("date");

                entity.Property(e => e.Extra)
                    .HasColumnName("extra")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FgDireto)
                    .HasColumnName("fg_direto")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FgParcelado)
                    .HasColumnName("fg_parcelado")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Historico)
                    .IsRequired()
                    .HasColumnName("historico")
                    .HasColumnType("varchar(400)");

                entity.Property(e => e.IdConta)
                    .HasColumnName("id_conta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdContaorigen)
                    .HasColumnName("id_contaorigen")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFornecedor)
                    .HasColumnName("id_fornecedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdMovimento)
                    .HasColumnName("id_movimento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPlanegamentoOrigen)
                    .HasColumnName("id_planegamento_origen")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSaldo)
                    .HasColumnName("id_saldo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NotaFiscal)
                    .IsRequired()
                    .HasColumnName("nota_fiscal")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.NumDoc)
                    .HasColumnName("num_doc")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasColumnName("origen")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Retencao)
                    .HasColumnName("retencao")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoExtra)
                    .HasColumnName("tipo_extra")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoOrigen)
                    .HasColumnName("tipo_origen")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TipoPago)
                    .HasColumnName("tipo_pago")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Plano>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("plano");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFaturamento)
                    .HasColumnName("id_faturamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTipo)
                    .HasColumnName("id_tipo")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.QtdFuncionarios)
                    .HasColumnName("qtd_funcionarios")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.QtdSocios)
                    .HasColumnName("qtd_socios")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PlanoContaEstatico>(entity =>
            {
                entity.ToTable("plano_conta_estatico");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Conta)
                    .HasColumnName("conta")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ContaContrapartida)
                    .HasColumnName("conta_contrapartida")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ContaTotalizadora)
                    .HasColumnName("conta_totalizadora")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdContrapartida)
                    .HasColumnName("id_contrapartida")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<ReciboFolhaPagamento>(entity =>
            {
                entity.HasKey(e => e.IdRecibo);

                entity.ToTable("recibo_folha_pagamento");

                entity.Property(e => e.IdRecibo)
                    .HasColumnName("id_recibo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataMa)
                    .HasColumnName("dataMA")
                    .HasColumnType("char(7)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdRequisitado)
                    .HasColumnName("id_requisitado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Inss)
                    .HasColumnName("inss")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Ir)
                    .HasColumnName("ir")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.PercentualInss)
                    .HasColumnName("percentual_inss")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.PercentualIr)
                    .HasColumnName("percentual_ir")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Prolabore)
                    .HasColumnName("prolabore")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.TipoRequisitado)
                    .HasColumnName("tipo_requisitado")
                    .HasColumnType("int(1)");

                entity.Property(e => e.ValorDependente)
                    .HasColumnName("valorDependente")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("'0.00'");
            });

            modelBuilder.Entity<ReciboGps>(entity =>
            {
                entity.HasKey(e => e.IdRecibo);

                entity.ToTable("recibo_gps");

                entity.Property(e => e.IdRecibo)
                    .HasColumnName("id_recibo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataMa)
                    .HasColumnName("dataMA")
                    .HasColumnType("char(7)");

                entity.Property(e => e.DataRegistro)
                    .HasColumnName("data_registro")
                    .HasColumnType("datetime");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValorInss)
                    .HasColumnName("valor_inss")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Regime>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("regime");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Regime1)
                    .HasColumnName("regime")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Remessas>(entity =>
            {
                entity.ToTable("remessas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<RescisaoFuncionario>(entity =>
            {
                entity.ToTable("rescisao_funcionario");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFuncionario)
                    .HasColumnName("id_funcionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdVerba)
                    .HasColumnName("id_verba")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantidade)
                    .HasColumnName("quantidade")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Valor).HasColumnName("valor");
            });

            modelBuilder.Entity<RespostasChamados>(entity =>
            {
                entity.HasKey(e => e.IdResposta);

                entity.ToTable("respostas_chamados");

                entity.Property(e => e.IdResposta)
                    .HasColumnName("id_resposta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataResposta)
                    .HasColumnName("data_resposta")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.FgAceita)
                    .HasColumnName("fg_aceita")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IdChamado)
                    .HasColumnName("id_chamado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrdenRespost)
                    .HasColumnName("orden_respost")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Resposta)
                    .IsRequired()
                    .HasColumnName("resposta")
                    .HasColumnType("text");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Retencoes>(entity =>
            {
                entity.HasKey(e => e.IdRetencao);

                entity.ToTable("retencoes");

                entity.Property(e => e.IdRetencao)
                    .HasColumnName("id_retencao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdImposto)
                    .HasColumnName("id_imposto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPlanegamento)
                    .HasColumnName("id_planegamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Saldos>(entity =>
            {
                entity.HasKey(e => e.IdSaldo);

                entity.ToTable("saldos");

                entity.Property(e => e.IdSaldo)
                    .HasColumnName("id_saldo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Conta)
                    .IsRequired()
                    .HasColumnName("conta")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Credito)
                    .HasColumnName("credito")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.DataCaixa)
                    .HasColumnName("data_caixa")
                    .HasColumnType("date");

                entity.Property(e => e.DataContabil)
                    .HasColumnName("data_contabil")
                    .HasColumnType("date");

                entity.Property(e => e.DataRegistro)
                    .HasColumnName("data_registro")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.Debito)
                    .HasColumnName("debito")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FgRetencao)
                    .HasColumnName("fg_retencao")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Historico)
                    .IsRequired()
                    .HasColumnName("historico")
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.IdConta)
                    .HasColumnName("id_conta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPlanegamento)
                    .HasColumnName("id_planegamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Saldo)
                    .HasColumnName("saldo")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<ServicoExtra>(entity =>
            {
                entity.ToTable("servico_extra");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Prazo)
                    .HasColumnName("prazo")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Servico)
                    .HasColumnName("servico")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("float(7,2)");
            });

            modelBuilder.Entity<Socios>(entity =>
            {
                entity.HasKey(e => e.IdSocio);

                entity.ToTable("socios");

                entity.Property(e => e.IdSocio)
                    .HasColumnName("id_socio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Admin)
                    .HasColumnName("admin")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Ci)
                    .IsRequired()
                    .HasColumnName("ci")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("cpf")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.DataAdmissao)
                    .HasColumnName("data_admissao")
                    .HasColumnType("date");

                entity.Property(e => e.DataDemissao)
                    .HasColumnName("data_demissao")
                    .HasColumnType("date");

                entity.Property(e => e.DataNascimento)
                    .HasColumnName("data_nascimento")
                    .HasColumnType("date");

                entity.Property(e => e.Endereco)
                    .HasColumnName("endereco")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.EstadoCivil)
                    .IsRequired()
                    .HasColumnName("estado_civil")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.EstadoOrgao)
                    .HasColumnName("estado_orgao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FgProlabore)
                    .HasColumnName("fg_prolabore")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IdCidade)
                    .HasColumnName("id_cidade")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Identidade)
                    .HasColumnName("identidade")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.LocalNascimento)
                    .IsRequired()
                    .HasColumnName("local_nascimento")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Mae)
                    .IsRequired()
                    .HasColumnName("mae")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.MotivoRecusa)
                    .HasColumnName("motivo_recusa")
                    .HasColumnType("text");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Nomemae)
                    .HasColumnName("nomemae")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Nomepai)
                    .HasColumnName("nomepai")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Nr)
                    .HasColumnName("nr")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Orgao)
                    .HasColumnName("orgao")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Pai)
                    .IsRequired()
                    .HasColumnName("pai")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.PercentualCapital)
                    .HasColumnName("percentual_capital")
                    .HasColumnType("float(5,2)");

                entity.Property(e => e.Pis)
                    .HasColumnName("pis")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Profissao)
                    .HasColumnName("profissao")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Prolabore)
                    .HasColumnName("prolabore")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.QtdDependentes)
                    .HasColumnName("qtd_dependentes")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Regime)
                    .HasColumnName("regime")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rua)
                    .HasColumnName("rua")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Validado)
                    .HasColumnName("validado")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ValorCapital)
                    .HasColumnName("valor_capital")
                    .HasColumnType("float(11,2)");
            });

            modelBuilder.Entity<SociosDocs>(entity =>
            {
                entity.HasKey(e => e.IdSocio);

                entity.ToTable("socios_docs");

                entity.Property(e => e.IdSocio)
                    .HasColumnName("id_socio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Soc1)
                    .HasColumnName("soc_1")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Soc2)
                    .HasColumnName("soc_2")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Soc3)
                    .HasColumnName("soc_3")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Soc4)
                    .HasColumnName("soc_4")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TabelaDeducaoDependente>(entity =>
            {
                entity.ToTable("tabela_deducao_dependente");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<TabelaInss>(entity =>
            {
                entity.ToTable("tabela_inss");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Percentual)
                    .HasColumnName("percentual")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ValorFim).HasColumnName("valor_fim");

                entity.Property(e => e.ValorInicio).HasColumnName("valor_inicio");
            });

            modelBuilder.Entity<TabelaIr>(entity =>
            {
                entity.ToTable("tabela_ir");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Percentual)
                    .HasColumnName("percentual")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ValorFim).HasColumnName("valor_fim");

                entity.Property(e => e.ValorInicio).HasColumnName("valor_inicio");
            });

            modelBuilder.Entity<TabelaSalarioFamila>(entity =>
            {
                entity.ToTable("tabela_salario_famila");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Valor).HasColumnName("valor");
            });

            modelBuilder.Entity<TabelaSalarioMinimo>(entity =>
            {
                entity.ToTable("tabela_salario_minimo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Valor).HasColumnName("valor");
            });

            modelBuilder.Entity<Tickets>(entity =>
            {
                entity.ToTable("tickets");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdRequisitado)
                    .HasColumnName("id_requisitado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Modulo)
                    .HasColumnName("modulo")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Motivo)
                    .HasColumnName("motivo")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TipoContas>(entity =>
            {
                entity.HasKey(e => e.IdTipo);

                entity.ToTable("tipo_contas");

                entity.Property(e => e.IdTipo)
                    .HasColumnName("id_tipo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Conta)
                    .IsRequired()
                    .HasColumnName("conta")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.IdConta)
                    .HasColumnName("id_conta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<TipoEmpresa>(entity =>
            {
                entity.HasKey(e => e.IdTipo);

                entity.ToTable("tipo_empresa");

                entity.Property(e => e.IdTipo)
                    .HasColumnName("id_tipo")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.DescTipo)
                    .IsRequired()
                    .HasColumnName("desc_tipo")
                    .HasColumnType("varchar(255)");
            });


            modelBuilder.Entity<UsuariosCbolso>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("usuarios_cbolso");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdArea)
                    .HasColumnName("id_area")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("senha")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<UsuariosEmpresas>(entity =>
            {
                entity.ToTable("usuarios_empresas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataCadastro)
                    .HasColumnName("data_cadastro")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.FaseCadastro)
                    .HasColumnName("fase_cadastro")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FgAddwords)
                    .HasColumnName("fg_addwords")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FgAtivo)
                    .HasColumnName("fg_ativo")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FlagWhatsFeira)
                    .HasColumnName("flag_whats_feira")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("senha")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TipoUsuario)
                    .HasColumnName("tipo_usuario")
                    .HasColumnType("tinyint(2)");
            });

            modelBuilder.Entity<VerbasFuncionarios>(entity =>
            {
                entity.ToTable("verbas_funcionarios");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFuncionario)
                    .HasColumnName("id_funcionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdVerba)
                    .HasColumnName("id_verba")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<VerbasGerais>(entity =>
            {
                entity.ToTable("verbas_gerais");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BaseCalculo)
                    .HasColumnName("base_calculo")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasColumnType("char(3)");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Obrigatorio)
                    .HasColumnName("obrigatorio")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sinal)
                    .HasColumnName("sinal")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TipoVerba)
                    .HasColumnName("tipo_verba")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'T'");

                entity.Property(e => e.Unidade)
                    .HasColumnName("unidade")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.Property(e => e.ValorUnidade)
                    .HasColumnName("valor_unidade")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<VerbasPermanentesEmpresas>(entity =>
            {
                entity.ToTable("verbas_permanentes_empresas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa)
                    .HasColumnName("id_empresa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdVerba)
                    .HasColumnName("id_verba")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<VerbasRescisorias>(entity =>
            {
                entity.ToTable("verbas_rescisorias");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasColumnType("char(5)");

                entity.Property(e => e.Comentario)
                    .HasColumnName("comentario")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Obrigatorio)
                    .HasColumnName("obrigatorio")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Sinal)
                    .HasColumnName("sinal")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.TipoVerba)
                    .HasColumnName("tipo_verba")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Unidade)
                    .HasColumnName("unidade")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.Property(e => e.ValorUnidade)
                    .HasColumnName("valor_unidade")
                    .HasColumnType("tinyint(1)");
            });
        }
    }
}
