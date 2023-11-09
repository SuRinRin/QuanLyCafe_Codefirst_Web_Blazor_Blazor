using B.API.Enitities;
using Microsoft.EntityFrameworkCore;

namespace B.API.EF
{
	public class QuanLyCafeDBContext : DbContext
	{
		public QuanLyCafeDBContext(DbContextOptions options) : base(options)
		{

		}
		public DbSet<SanPham> sanPhams {  get; set; } 
		public DbSet<LoaiSanPham> loaiSanPhams {  get; set; } 
		public DbSet<Sale> sales {  get; set; } 
		public DbSet<PhaChe> phaChes {  get; set; } 
		public DbSet<NguyenLieu> nguyenLieus {  get; set; } 
		public DbSet<NhanVien> nhanViens {  get; set; } 
		public DbSet<HoaDon> hoaDons {  get; set; } 
		public DbSet<HoaDonChiTiet> hoaDonChiTiets {  get; set; } 
		public DbSet<Customer> customers {  get; set; } 
		public DbSet<Voucher> vouchers {  get; set; } 
		public DbSet<DichVuPhatSinh> dichVuPhatSinhs {  get; set; } 
		public DbSet<MemberShipRank> memberShipRanks {  get; set; } 
	}
}
