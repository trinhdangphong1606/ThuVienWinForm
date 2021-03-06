USE [test]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[IdDanhMuc] [int] IDENTITY(1,1) NOT NULL,
	[TenDanhMuc] [nvarchar](50) NULL,
	[NoiDungDanhMuc] [nvarchar](1024) NULL,
 CONSTRAINT [PK__DanhMuc__7E5B713D187B0398] PRIMARY KEY CLUSTERED 
(
	[IdDanhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiMuonSach]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiMuonSach](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](200) NULL,
	[SoDienThoai] [varchar](10) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[Email] [nvarchar](200) NULL,
	[NamSinh] [int] NULL,
 CONSTRAINT [PK__NguoiMuo__3214EC07A463C261] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuonSach]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuonSach](
	[PhieuId] [int] IDENTITY(1,1) NOT NULL,
	[NguoiMuonSachId] [int] NOT NULL,
	[SachId] [int] NOT NULL,
	[NgayMuon] [datetime] NULL,
	[NgayDuKienTra] [datetime] NULL,
	[NgayTraSach] [datetime] NULL,
	[TrangThai] [nvarchar](100) NULL,
 CONSTRAINT [PK__PhieuMuo__CB0C4A5584DC1EF8] PRIMARY KEY CLUSTERED 
(
	[PhieuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanTriVien]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanTriVien](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [varchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[NamSinh] [int] NULL,
	[MatKhau] [nvarchar](1000) NULL,
	[HoTen] [nvarchar](50) NULL,
	[KeyRestore] [nvarchar](50) NULL,
	[SoDienThoai] [varchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Quyen] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenSach] [nvarchar](30) NULL,
	[NamXuatBan] [int] NULL,
	[DanhMucID] [int] NULL,
	[TacGia] [nvarchar](50) NULL,
	[NgonNgu] [nvarchar](20) NULL,
	[NoiDungSach] [nvarchar](1024) NULL,
	[SoLuong] [int] NULL,
	[TrangThai] [nvarchar](20) NULL,
 CONSTRAINT [PK__Sach__3214EC07F92CE154] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PhieuMuonSach]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuonSach_NguoiMuonSach] FOREIGN KEY([NguoiMuonSachId])
REFERENCES [dbo].[NguoiMuonSach] ([Id])
GO
ALTER TABLE [dbo].[PhieuMuonSach] CHECK CONSTRAINT [FK_PhieuMuonSach_NguoiMuonSach]
GO
ALTER TABLE [dbo].[PhieuMuonSach]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuonSach_Sach] FOREIGN KEY([SachId])
REFERENCES [dbo].[Sach] ([Id])
GO
ALTER TABLE [dbo].[PhieuMuonSach] CHECK CONSTRAINT [FK_PhieuMuonSach_Sach]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_DanhMuc_Sach] FOREIGN KEY([DanhMucID])
REFERENCES [dbo].[DanhMuc] ([IdDanhMuc])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_DanhMuc_Sach]
GO
/****** Object:  StoredProcedure [dbo].[TimMaPhieu]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TimMaPhieu] @maphieu varchar(10)
as
SELECT pms.PhieuId,nms.HoTen,s.TenSach,pms.NgayMuon,pms.NgayDuKienTra,pms.NgayTraSach,pms.TrangThai
FROM PhieuMuonSach pms, NguoiMuonSach nms, Sach s 
WHERE pms.NguoiMuonSachId = nms.Id and pms.SachID = s.ID and PhieuId like '%' + @maphieu+ '%'
GO
/****** Object:  StoredProcedure [dbo].[TimNguoiMuonTheoMa]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TimNguoiMuonTheoMa] @ma int
  as	
  select *
  from NguoiMuonSach
  where id=@ma
GO
/****** Object:  StoredProcedure [dbo].[TimPhieuTheoNgay]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TimPhieuTheoNgay] @ngay int, @thang int, @nam int
  as
  SELECT pms.PhieuId,nms.HoTen,s.TenSach,pms.NgayMuon,pms.NgayDuKienTra,pms.NgayTraSach 
  FROM PhieuMuonSach pms, NguoiMuonSach nms, Sach s 
  WHERE pms.NguoiMuonSachId = nms.Id and pms.SachID = s.ID
  and day(pms.NgayMuon)=@ngay AND Month(pms.NgayMuon)=@thang AND year(pms.NgayMuon)=@nam
GO
/****** Object:  StoredProcedure [dbo].[TimPhieuTheoTen]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TimPhieuTheoTen] @ten nvarchar(20)
as
SELECT pms.PhieuId,nms.HoTen,s.TenSach,pms.NgayMuon,pms.NgayDuKienTra,pms.NgayTraSach 
FROM PhieuMuonSach pms, NguoiMuonSach nms, Sach s 
WHERE pms.NguoiMuonSachId = nms.Id and pms.SachID = s.ID and nms.HoTen like N'%'+@ten+'%'
GO
/****** Object:  StoredProcedure [dbo].[TimQTVTheoQuyen]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  Create procedure [dbo].[TimQTVTheoQuyen] @quyen nvarchar(30)
  as
  Select * 
  from QuanTriVien 
  where Quyen=@quyen
GO
/****** Object:  StoredProcedure [dbo].[TimQuanTriVien]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[TimQuanTriVien] @ten nvarchar(30)
  as
  Select * 
  from QuanTriVien 
  where HoTen like '%'+@ten+ '%'
GO
/****** Object:  StoredProcedure [dbo].[TimQuanTriVienTheoMa]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[TimQuanTriVienTheoMa] @ma int
  as
  Select * 
  from QuanTriVien 
  where Id=@ma
GO
/****** Object:  StoredProcedure [dbo].[TimSach]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TimSach] @ten nvarchar(30)
  as	
  select Id,TenSach
  from Sach
  where TenSach like '%'+@ten+ '%'
GO
/****** Object:  StoredProcedure [dbo].[TimSachTheoTen]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TimSachTheoTen] @ten nvarchar(30)
  as
  SELECT s.Id, s.TenSach, s.NamXuatBan, dm.TenDanhMuc, s.TacGia, s.NgonNgu, s.NoiDungSach, s.SoLuong , s.TrangThai
  FROM Sach s, DanhMuc dm
  where s.DanhMucID = dm.IdDanhMuc and s.TenSach like '%'+@ten+ '%'
GO
/****** Object:  StoredProcedure [dbo].[TimSachTheoTin]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TimSachTheoTin] @ten nvarchar(30)
  as
  SELECT s.Id, s.TenSach, s.NamXuatBan, dm.TenDanhMuc, s.TacGia, s.NgonNgu, s.NoiDungSach, s.SoLuong 
  FROM Sach s, DanhMuc dm
  where s.DanhMucID = dm.IdDanhMuc and s.TenSach like '%'+@ten+ '%'
GO
/****** Object:  StoredProcedure [dbo].[TimSachTrongTheoTen]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TimSachTrongTheoTen] @ten nvarchar(30)
  as
  SELECT s.Id, s.TenSach, s.NamXuatBan, dm.TenDanhMuc, s.TacGia, s.NgonNgu, s.NoiDungSach, s.SoLuong , s.TrangThai
  FROM Sach s, DanhMuc dm
  where s.DanhMucID = dm.IdDanhMuc and s.TenSach like '%'+@ten+ '%' and s.TrangThai =N'Trống'
GO
/****** Object:  StoredProcedure [dbo].[TimTenNguoiMuon]    Script Date: 07/02/2020 2:03:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TimTenNguoiMuon] @ten nvarchar(30)
  as	
  select *
  from NguoiMuonSach
  where HoTen like '%'+@ten+ '%'
GO
