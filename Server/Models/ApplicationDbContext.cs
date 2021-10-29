using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ScaGuerrero.Server.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<Ciclos> Ciclos { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Contratos> Contratos { get; set; }
        public virtual DbSet<Detalleventas> Detalleventas { get; set; }
        public virtual DbSet<Detalletmp> Detalletmp { get; set; }
        public virtual DbSet<Diapositivas> Diapositivas { get; set; }
        public virtual DbSet<Imagenes> Imagenes { get; set; }
        public virtual DbSet<Parametros> Parametros { get; set; }
        public virtual DbSet<Partidas> Partidas { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Ventas> Ventas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;uid=root;pwd=2505mfox;database=scaguerrero", x => x.ServerVersion("5.7.17-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulos>(entity =>
            {
                entity.ToTable("articulos");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Almacen)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Codigo)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Costo).HasColumnType("decimal(11,2)");

                entity.Property(e => e.CveSat)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Existencia).HasColumnType("decimal(11,2)");

                entity.Property(e => e.IdImagen).HasColumnType("int(11)");

                entity.Property(e => e.Iva).HasColumnType("decimal(11,2)");

                entity.Property(e => e.Linea)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Marca)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Precio2).HasColumnType("decimal(11,2)");

                entity.Property(e => e.PrecioCredito).HasColumnType("decimal(11,2)");

                entity.Property(e => e.PrecioPublico).HasColumnType("decimal(11,2)");

                entity.Property(e => e.StockMinimo).HasColumnType("decimal(11,2)");

                entity.Property(e => e.UltimaCompra)
                .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UltimaVenta)
                .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Unidad)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UnidadSat)
                    .HasColumnName("UnidadSAT")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ciclos>(entity =>
            {
                entity.ToTable("ciclos");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.ToTable("clientes");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AtnCobranza)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AtnVentas)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Calle)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ciudad)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Colonia)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cp)
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Curp)
                    .HasColumnName("CURP")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EMail)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Estado)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdImagen).HasColumnType("int(11)");

                entity.Property(e => e.Localidad)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Numero)
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasColumnType("varchar(13)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Saldo).HasColumnType("decimal(11,2)");

                entity.Property(e => e.Telefono)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Telefono2)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Contratos>(entity =>
            {
                entity.ToTable("contratos");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Cultivo)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Curpcopia).HasColumnName("CURPCopia");

                entity.Property(e => e.Curporiginal).HasColumnName("CURPOriginal");

                entity.Property(e => e.Densidad)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ejido)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.Folio).HasColumnType("int(11)");

                entity.Property(e => e.Garantia)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdCiclo)
                    .HasColumnName("idCiclo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("idCliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Interes).HasColumnType("decimal(11,2)");

                entity.Property(e => e.Jurisdiccion)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MontoCredito).HasColumnType("decimal(11,2)");

                entity.Property(e => e.Observaciones)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservacionesGarantia)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Propiedad)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Seguro)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Superficie)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Variedad)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Detalleventas>(entity =>
            {
                entity.ToTable("detalleventas");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(11,2)");

                entity.Property(e => e.Descuento).HasColumnType("decimal(11,2)");

                entity.Property(e => e.IdArticulo).HasColumnType("int(11)");

                entity.Property(e => e.IdVenta).HasColumnType("int(11)");

                entity.Property(e => e.Importe).HasColumnType("decimal(11,2)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(11,2)");

                entity.Property(e => e.Precio).HasColumnType("decimal(11,2)");
            });

            modelBuilder.Entity<Detalletmp>(entity =>
            {
                entity.ToTable("detalletmp");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario).HasColumnType("int(11)");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(11,2)");

                entity.Property(e => e.Descuento).HasColumnType("decimal(11,2)");

                entity.Property(e => e.IdArticulo).HasColumnType("int(11)");
                
                entity.Property(e => e.Importe).HasColumnType("decimal(11,2)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(11,2)");

                entity.Property(e => e.Precio).HasColumnType("decimal(11,2)");
            });

            modelBuilder.Entity<Diapositivas>(entity =>
            {
                entity.ToTable("diapositivas");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdImagen).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Imagenes>(entity =>
            {
                entity.ToTable("imagenes");

                entity.Property(e => e.Id).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Parametros>(entity =>
            {
                entity.ToTable("parametros");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FolioCompras)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FolioVentas)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasColumnType("varchar(13)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UrlCertificado)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UrlKey)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Partidas>(entity =>
            {
                entity.ToTable("partidas");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(11,2)");

                entity.Property(e => e.Descuento).HasColumnType("decimal(11,2)");

                entity.Property(e => e.IdArticulo).HasColumnType("int(11)");

                entity.Property(e => e.Importe).HasColumnType("decimal(11,2)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(11,2)");

                entity.Property(e => e.Precio).HasColumnType("decimal(11,2)");

                entity.Property(e => e.Usuario).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.ToTable("perfil");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.ToTable("proveedores");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AtnCobranza)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AtnVentas)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Calle)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ciudad)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Colonia)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cp)
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdImagen).HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Numero)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Poblacion)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasColumnType("varchar(13)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Saldo).HasColumnType("decimal(11,2)");

                entity.Property(e => e.Telefono)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Telefono2)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdImagen).HasColumnType("int(11)");

                entity.Property(e => e.Usuario)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombre)
                   .HasColumnType("varchar(100)")
                   .HasCharSet("utf8")
                   .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Perfil)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Telefono)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ventas>(entity =>
            {
                entity.ToTable("ventas");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Anticipo).HasColumnType("decimal(11,2)");

                entity.Property(e => e.Descuento).HasColumnType("decimal(11,2)");

                entity.Property(e => e.FechaElaboracion).HasColumnType("date");

                entity.Property(e => e.FechaTimbrado).HasColumnType("date");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.Folio).HasColumnType("int(11)");

                entity.Property(e => e.FormaPago)
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdCiclo).HasColumnType("int(11)");

                entity.Property(e => e.IdCliente).HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario).HasColumnType("int(11)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(11,2)");

                entity.Property(e => e.MetodoPago)
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Observaciones)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(11,2)");

                entity.Property(e => e.Total).HasColumnType("decimal(11,2)");

                entity.Property(e => e.UsoCfdi)
                    .HasColumnName("UsoCFDI")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
