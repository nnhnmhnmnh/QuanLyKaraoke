CREATE DATABASE QuanLyKaraoke
GO
USE QuanLyKaraoke
CREATE TABLE TaiKhoan(
	TenDangNhap VARCHAR(20),
	MatKhau VARCHAR(20) NOT NULL,
	PRIMARY KEY (TenDangNhap)
)
CREATE TABLE KhachHang(
	MaKhachHang VARCHAR(10),
	TenDangNhap VARCHAR(20),
	HoTen NVARCHAR(50) NOT NULL,
	SDT VARCHAR(10) NOT NULL,
	Email VARCHAR(50),
	GioiTinh NVARCHAR(10) NOT NULL,
	NgaySinh DATE NOT NULL,
	PRIMARY KEY (MaKhachHang),
	FOREIGN KEY (TenDangNhap) REFERENCES TaiKhoan(TenDangNhap)
)
CREATE TABLE NhanVien(
	MaNhanVien VARCHAR(10),
	TenDangNhap VARCHAR(20),
	HoTen NVARCHAR(50) NOT NULL,
	CCCD VARCHAR(20) NOT NULL,
	SDT VARCHAR(10) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	GioiTinh NVARCHAR(10) NOT NULL,
	NgaySinh DATE NOT NULL,
	ChucVu NVARCHAR(20) NOT NULL,
	PRIMARY KEY (MaNhanVien),
	FOREIGN KEY (TenDangNhap) REFERENCES TaiKhoan(TenDangNhap)
)
CREATE TABLE PhongHat(
	MaPhong VARCHAR(10),
	LoaiPhong NVARCHAR(50) NOT NULL,
	SoNguoiToiDa INT NOT NULL,
	GiaTheoGio INT NOT NULL,
	TrangThai NVARCHAR(50) NOT NULL,
	PRIMARY KEY (MaPhong)
)
CREATE TABLE PhieuThuePhong(
	MaPhieu VARCHAR(20),
	MaKhachHang VARCHAR(10),
	MaPhong VARCHAR(10),
	ThoiGianThuePhong DATETIME,
	ThoiGianTraPhong DATETIME,
	PRIMARY KEY (MaPhieu),
	FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
	FOREIGN KEY (MaPhong) REFERENCES PhongHat(MaPhong),
)
CREATE TABLE DichVu(
	MaDichVu VARCHAR(10),
	LoaiDichVu NVARCHAR(10) NOT NULL,
	TenDichVu NVARCHAR(50) NOT NULL,
	DonGia INT NOT NULL,
	TonKho INT NOT NULL,
	PRIMARY KEY (MaDichVu)
)
CREATE TABLE HoaDon(
	MaHoaDon VARCHAR(20),
	MaPhieu VARCHAR(20),
	MaKhachHang VARCHAR(10),
	NgayLap DATETIME,
	TongTien INT,
	PRIMARY KEY (MaHoaDon),
	FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
	FOREIGN KEY (MaPhieu) REFERENCES PhieuThuePhong(MaPhieu)
)
CREATE TABLE ChiTietHoaDon(
	MaCTHD VARCHAR(20),
	MaHoaDon VARCHAR(20),
	MaDichVu VARCHAR(10),
	SoLuong INT NOT NULL,
	ThanhTien INT NOT NULL,
	PRIMARY KEY (MaCTHD),
	FOREIGN KEY (MaDichVu) REFERENCES DichVu(MaDichVu),
	FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon)
)

INSERT INTO TaiKhoan VALUES ('admin','123456')
INSERT INTO TaiKhoan VALUES ('tieptan','123456')
INSERT INTO TaiKhoan VALUES ('phucvu','123456')
INSERT INTO TaiKhoan VALUES ('quanlykho','123456')
INSERT INTO TaiKhoan VALUES (' ',' ')

INSERT INTO KhachHang VALUES ('kh0001',' ','KH 1','0124912491','kh1@gmail.com','Nam','1/21/2011')
INSERT INTO KhachHang VALUES ('kh0002',' ','KH 2','0124912492','kh2@gmail.com','Nam','5/26/2019')
INSERT INTO KhachHang VALUES ('kh0003',' ','KH 3','0124912493','kh3@gmail.com','Nam','9/17/2015')

INSERT INTO NhanVien VALUES ('nv0001','tieptan',N'Họ Tên NV','292742873478','0124912491','kh1@gmail.com',N'Địa chỉ sdfsjau weioufs fsgjweiof sdfi',N'Nam','1/21/2011',N'Chức vụ')
INSERT INTO NhanVien VALUES ('nv0002','tieptan',N'Họ Tên NV2','292742873479','0124912492','nv2@gmail.com',N'Địa chỉ asjkd cjfdjasf ffa adfg gfhgh jjd hdghdgf',N'Nữ','1/29/2011',N'Chức vụ')
INSERT INTO NhanVien VALUES ('nv0003','tieptan',N'Họ Tên NV3','292742873499','0124912493','nv3@gmail.com',N'Địa chỉ ajfsdlkf jfajasd fja;eiorw ifjsd;f jasdkl;f; sdfj',N'Nữ','5/21/2011',N'Chức vụ')

INSERT INTO PhongHat VALUES ('p0001','loai1',8,1000,'0')
INSERT INTO PhongHat VALUES ('p0002','loai2',8,2000,'0')
INSERT INTO PhongHat VALUES ('p0003','loai3',8,3000,'0')

INSERT INTO HoaDon VALUES('2482094285','kh0001','','')