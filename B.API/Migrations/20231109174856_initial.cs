using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace B.API.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "loaiSanPhams",
                columns: table => new
                {
                    IdLoaiSanPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaiSanPhams", x => x.IdLoaiSanPham);
                });

            migrationBuilder.CreateTable(
                name: "memberShipRanks",
                columns: table => new
                {
                    IdRank = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PointsNeed = table.Column<int>(type: "int", nullable: true),
                    Discount = table.Column<float>(type: "real", nullable: true),
                    RankName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_memberShipRanks", x => x.IdRank);
                });

            migrationBuilder.CreateTable(
                name: "nguyenLieus",
                columns: table => new
                {
                    IdNguyeLieu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNguyenLieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<float>(type: "real", nullable: true),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayHetHan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nguyenLieus", x => x.IdNguyeLieu);
                });

            migrationBuilder.CreateTable(
                name: "nhanViens",
                columns: table => new
                {
                    IdNhanVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoginName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.IdNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "vouchers",
                columns: table => new
                {
                    IdVoucher = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiamTien = table.Column<float>(type: "real", nullable: true),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DieuKienApDung = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vouchers", x => x.IdVoucher);
                });

            migrationBuilder.CreateTable(
                name: "sanPhams",
                columns: table => new
                {
                    IdSanPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<float>(type: "real", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    Thue = table.Column<float>(type: "real", nullable: true),
                    LoaiSanPhamIdLoaiSanPham = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhams", x => x.IdSanPham);
                    table.ForeignKey(
                        name: "FK_sanPhams_loaiSanPhams_LoaiSanPhamIdLoaiSanPham",
                        column: x => x.LoaiSanPhamIdLoaiSanPham,
                        principalTable: "loaiSanPhams",
                        principalColumn: "IdLoaiSanPham");
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    IdCustomer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RankId = table.Column<int>(type: "int", nullable: true),
                    MemberShipRankIdRank = table.Column<int>(type: "int", nullable: true),
                    Point = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.IdCustomer);
                    table.ForeignKey(
                        name: "FK_customers_memberShipRanks_MemberShipRankIdRank",
                        column: x => x.MemberShipRankIdRank,
                        principalTable: "memberShipRanks",
                        principalColumn: "IdRank");
                });

            migrationBuilder.CreateTable(
                name: "phaChes",
                columns: table => new
                {
                    IdPhaChe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CongThuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSanPham = table.Column<int>(type: "int", nullable: false),
                    IdNguyenLieu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phaChes", x => x.IdPhaChe);
                    table.ForeignKey(
                        name: "FK_phaChes_nguyenLieus_IdNguyenLieu",
                        column: x => x.IdNguyenLieu,
                        principalTable: "nguyenLieus",
                        principalColumn: "IdNguyeLieu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_phaChes_sanPhams_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "sanPhams",
                        principalColumn: "IdSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sales",
                columns: table => new
                {
                    IdSale = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhanTram = table.Column<float>(type: "real", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdSanPham = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sales", x => x.IdSale);
                    table.ForeignKey(
                        name: "FK_sales_sanPhams_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "sanPhams",
                        principalColumn: "IdSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    IDHoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayBan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdNhanVien = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    VoucherIdVoucher = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.IDHoaDon);
                    table.ForeignKey(
                        name: "FK_hoaDons_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "IdCustomer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDons_nhanViens_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "nhanViens",
                        principalColumn: "IdNhanVien",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDons_vouchers_VoucherIdVoucher",
                        column: x => x.VoucherIdVoucher,
                        principalTable: "vouchers",
                        principalColumn: "IdVoucher");
                });

            migrationBuilder.CreateTable(
                name: "dichVuPhatSinhs",
                columns: table => new
                {
                    IdDichVu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChiTiet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoTien = table.Column<float>(type: "real", nullable: true),
                    HoaDonIDHoaDon = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dichVuPhatSinhs", x => x.IdDichVu);
                    table.ForeignKey(
                        name: "FK_dichVuPhatSinhs_hoaDons_HoaDonIDHoaDon",
                        column: x => x.HoaDonIDHoaDon,
                        principalTable: "hoaDons",
                        principalColumn: "IDHoaDon");
                });

            migrationBuilder.CreateTable(
                name: "hoaDonChiTiets",
                columns: table => new
                {
                    IDHoaDonChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayXuatDon = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TongGiaTriHoaDon = table.Column<float>(type: "real", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    GiaBan = table.Column<float>(type: "real", nullable: true),
                    IdCustomer = table.Column<int>(type: "int", nullable: false),
                    IdSanPham = table.Column<int>(type: "int", nullable: false),
                    IdVoucher = table.Column<int>(type: "int", nullable: false),
                    HoaDonIDHoaDon = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonChiTiets", x => x.IDHoaDonChiTiet);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_customers_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "customers",
                        principalColumn: "IdCustomer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_hoaDons_HoaDonIDHoaDon",
                        column: x => x.HoaDonIDHoaDon,
                        principalTable: "hoaDons",
                        principalColumn: "IDHoaDon");
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_vouchers_IdVoucher",
                        column: x => x.IdVoucher,
                        principalTable: "vouchers",
                        principalColumn: "IdVoucher",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTietSanPham",
                columns: table => new
                {
                    HoaDonChiTietsIDHoaDonChiTiet = table.Column<int>(type: "int", nullable: false),
                    SanPhamIdSanPham = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTietSanPham", x => new { x.HoaDonChiTietsIDHoaDonChiTiet, x.SanPhamIdSanPham });
                    table.ForeignKey(
                        name: "FK_HoaDonChiTietSanPham_hoaDonChiTiets_HoaDonChiTietsIDHoaDonChiTiet",
                        column: x => x.HoaDonChiTietsIDHoaDonChiTiet,
                        principalTable: "hoaDonChiTiets",
                        principalColumn: "IDHoaDonChiTiet",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTietSanPham_sanPhams_SanPhamIdSanPham",
                        column: x => x.SanPhamIdSanPham,
                        principalTable: "sanPhams",
                        principalColumn: "IdSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customers_MemberShipRankIdRank",
                table: "customers",
                column: "MemberShipRankIdRank");

            migrationBuilder.CreateIndex(
                name: "IX_dichVuPhatSinhs_HoaDonIDHoaDon",
                table: "dichVuPhatSinhs",
                column: "HoaDonIDHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_HoaDonIDHoaDon",
                table: "hoaDonChiTiets",
                column: "HoaDonIDHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_IdCustomer",
                table: "hoaDonChiTiets",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_IdVoucher",
                table: "hoaDonChiTiets",
                column: "IdVoucher");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTietSanPham_SanPhamIdSanPham",
                table: "HoaDonChiTietSanPham",
                column: "SanPhamIdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_CustomerId",
                table: "hoaDons",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_IdNhanVien",
                table: "hoaDons",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_VoucherIdVoucher",
                table: "hoaDons",
                column: "VoucherIdVoucher");

            migrationBuilder.CreateIndex(
                name: "IX_phaChes_IdNguyenLieu",
                table: "phaChes",
                column: "IdNguyenLieu");

            migrationBuilder.CreateIndex(
                name: "IX_phaChes_IdSanPham",
                table: "phaChes",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_sales_IdSanPham",
                table: "sales",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_LoaiSanPhamIdLoaiSanPham",
                table: "sanPhams",
                column: "LoaiSanPhamIdLoaiSanPham");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dichVuPhatSinhs");

            migrationBuilder.DropTable(
                name: "HoaDonChiTietSanPham");

            migrationBuilder.DropTable(
                name: "phaChes");

            migrationBuilder.DropTable(
                name: "sales");

            migrationBuilder.DropTable(
                name: "hoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "nguyenLieus");

            migrationBuilder.DropTable(
                name: "sanPhams");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "loaiSanPhams");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "nhanViens");

            migrationBuilder.DropTable(
                name: "vouchers");

            migrationBuilder.DropTable(
                name: "memberShipRanks");
        }
    }
}
