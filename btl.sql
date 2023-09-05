CREATE DATABASE QLTTNN
USE QLTTNN
go

CREATE TABLE NguoiDung
(
	TenDangNhap VARCHAR(30) PRIMARY KEY,
	MatKhau VARCHAR(128) NOT NULL,
	TrangThai BIT NOT NULL
)
create TABLE NgoaiNgu
(
	MaNgoaiNgu VARCHAR(3) PRIMARY KEY ,
	TenNgoaiNgu NVARCHAR(30) NOT NULL UNIQUE,
	NguoiSua varchar(30) references NguoiDung(TenDangNhap),
	ThoiDiem DATETIME NOT NULL
)

create table GiaoVien
(
	MaGiaoVien int identity primary key,
	Ho nvarchar(15) not null,
	Ten nvarchar(15) not null,
	NgaySinh date not null,
	GioiTinh bit,
	DiaChi nvarchar(100) not null,
	DienThoai varchar(10) not null unique,
	Email varchar(50) not null unique,
)
create table BangCap
(
	MaBangCap varchar(3) primary key,
	TenBangCap nvarchar(30) not null unique,
)
create table TrinhDoGiaoVien
(
	MaGiaoVien int not null references GiaoVien(MaGiaoVien),
	MaNgoaiNgu varchar(3) not null references NgoaiNgu(MaNgoaiNgu),
	MaBangCap varchar(3) not null references BangCap(MaBangCap),
	GhiChu nvarchar(30),
	primary key(MaGiaoVien,MaNgoaiNgu,MaBangCap)
)
create table Lop
(
	MaLop varchar(15) primary key,
	TenLop nvarchar(30) not null unique,
	MaGiaoVien int not null references GiaoVien(MaGiaoVien),
	NgayBatDau date not null,
	NgayKetThuc date,
	MaNgoaiNgu varchar(3) not null references NgoaiNgu(MaNgoaiNgu),
	DiaDiem nvarchar(50) not null,
	ThoiGian nvarchar(50) not null,
	GhiChu nvarchar(100),
)
create table HocVien
(
	MaHocVien int identity primary key,
	Ho nvarchar(15) not null,
	Ten nvarchar(15) not null,
	NgaySinh date not null,
	GioiTinh bit,
	DiaChi nvarchar(100) not null,
	DienThoai varchar(10) not null unique,
	Email varchar(50) not null unique,
)
create table DangKy
(
	MaHocVien int not null references HocVien(MaHocVien),
	MaLop varchar(15) not null references Lop(MaLop),
	Diem float,
	primary key(MaHocVien,MaLop)
)
CREATE TABLE ChucNang
(
	MaChucNang INT PRIMARY KEY,
	TenChucNang VARCHAR(50) NOT NULL UNIQUE,
	TrangThai BIT NOT NULL
)
insert ChucNang values (1,N'QuanLyNgoaiNgu',1)
insert ChucNang values (2,N'QuanLyBangCap',1)
insert ChucNang values (3,N'QuanLyHocVien',1)
insert ChucNang values (4,N'QuanLyGiaoVien',1)
insert ChucNang values (5,N'QuanLyNguoiDung',1)
insert ChucNang values (6,N'QuanLyLop',1)
insert ChucNang values (7,N'QuanLyNhatKy',1)
insert ChucNang values (8,N'QuanLyChucNang',1)
insert ChucNang values (9,N'ThemGiaoVien',1)
insert ChucNang values (10,N'ThemHocVien',1)

CREATE TABLE PhanQuyen
(
	TenDangNhap VARCHAR(30) NOT NULL REFERENCES NguoiDung(TenDangNhap),
	MaChucNang INT NOT NULL REFERENCES ChucNang(MaChucNang),
	PRIMARY KEY(TenDangNhap,MaChucNang)
)
CREATE TABLE NhatKy (
	MaNhatKy INT IDENTITY PRIMARY KEY,
	TenDangNhap VARCHAR(30) NOT NULL REFERENCES NguoiDung(TenDangNhap),
	ThoiDiem DATETIME NOT NULL,
	NoiDung NVARCHAR(200) NOT NULL
)

create Proc USPaddGiaoVien
@ho nvarchar(15), @ten nvarchar(15), 
@ngaySinh datetime, @gioiTinh bit, @diaChi nvarchar(100),
@dienThoai varchar(10), @email varchar(50)
as 
begin 
	insert GiaoVien values(@ho, @ten, @ngaySinh, @gioiTinh, @diaChi, @dienThoai, @email)
end

create Proc USPupdateGiaoVien
@maGiaoVien int,
@ho nvarchar(15), @ten nvarchar(15), @ngaySinh datetime, 
@gioiTinh bit, @diaChi nvarchar(100), @dienThoai varchar(10), @email varchar(50)
as 
begin 
	Update GiaoVien set @Ho=ho, Ten=@ten, NgaySinh=@ngaySinh, 
	GioiTinh=@gioiTinh, DiaChi=@diaChi,
	DienThoai=@dienThoai, Email=@email 
	where MaGiaoVien=@maGiaoVien
end 


create proc USPaddTrinhDoGiaoVien
@maGiaoVien int, @maNgoaiNgu varchar(3), @maBangCap varchar(3), @ghiChu nvarchar(30)
as 
begin
	declare @count int
	set @count = ( select count(*) from TrinhDoGiaoVien
	inner join NgoaiNgu on TrinhDoGiaoVien.MaNgoaiNgu = NgoaiNgu.MaNgoaiNgu
	inner join BangCap on TrinhDoGiaoVien.MaBangCap = BangCap.MaBangCap
	where MaGiaoVien = @maGiaoVien and TrinhDoGiaoVien.MaNgoaiNgu = @maNgoaiNgu and TrinhDoGiaoVien.MaBangCap = @maBangCap )
	if @count > 0
		throw 50000, N'Bằng cấp ngoại ngữ này đã có trong trình đọ giáo viên của người này', 1
	else
		insert TrinhDoGiaoVien values(@maGiaoVien, @maNgoaiNgu, @maBangCap, @ghiChu)
end

create Function UFloadTrinhDoGiaoVien
(@maGiaoVien int)
returns Table
as
return 
	select n.TenNgoaiNgu, b.TenBangCap, t.GhiChu  
	from TrinhDoGiaoVien as t, NgoaiNgu as N, BangCap as b
	where MaGiaoVien = @maGiaoVien and t.MaNgoaiNgu = n.MaNgoaiNgu and t.MaBangCap = b.MaBangCap

create proc USPxoaTrinhDoGiaoVien
@maGiaoVien int, @maNgoaiNgu varchar(3), @maBangCap varchar(3)
as
begin
	delete TrinhDoGiaoVien where MaGiaoVien=@maGiaoVien and MaNgoaiNgu=@maNgoaiNgu and MaBangCap=@maBangCap
end 

create FUNCTION UFxemTrinhDoGiaoVienByMaGiaoVien
( @maGiaoVien varchar(3) )
RETURNS TABLE 
AS 
	RETURN 
	SELECT TenNgoaiNgu, TenBangCap, GhiChu 
From trinhDoGiaoVien 
Inner Join NgoaiNgu ON TrinhDoGiaoVien.MaNgoaiNgu = NgoaiNgu.MaNgoaiNgu
Inner Join BangCap ON TrinhDoGiaoVien.MaBangCap = BangCap.MaBangCap
WHERE 1=1 and dbo.TrinhDoGiaoVien.MaGiaoVien = @maGiaoVien

create Proc USPxoaGiaoVien
@maGiaoVien varchar(3)
as 
begin 
	declare @count int;
	set @count = (select count(*) from TrinhDoGiaoVien where TrinhDoGiaoVien.MaGiaoVien = @maGiaoVien)
	if @count > 0
		throw 50000, N'Còn lớp liên qua tới giáo viên', 1;
	else begin 
		set @count = (select count(*) from Lop where Lop.MaGiaoVien = @maGiaoVien)
		if @count > 0
			throw 50000, N'Còn lớp liên qua tới giáo viên', 1;
		else 
			Delete GiaoVien where MaGiaoVien = @maGiaoVien
		end
end 

create proc USPthemNgoaiNgu
@maNgoaiNgu VARCHAR(3), @tenNgoaiNgu NVARCHAR(30), @nguoiDung varchar(30)
AS 
BEGIN
	DECLARE @count INT;
	SET @count = (SELECT COUNT(*) FROM dbo.NgoaiNgu WHERE MaNgoaiNgu = @maNgoaiNgu);
	IF @count > 0
		THROW 50000, N'Trùng mã ngoại ngữ', 1;
	ELSE BEGIN
		SET @count = (SELECT COUNT(*) FROM dbo.NgoaiNgu WHERE TenNgoaiNgu = @tenNgoaiNgu);
		IF @count > 0
			THROW 50000, N'Trùng mã tên ngoại ngữ', 1;
		ELSE 
			INSERT dbo.NgoaiNgu VALUES(@maNgoaiNgu, @tenNgoaiNgu, @nguoiDung, GetDate())
		END	
END

create Function UFloadDangKyByMaHocVien
(@maHocVien int)
returns table 
as 
	return 
	select l.TenLop, d.Diem from DangKy as d, Lop as l
	where d.MaHocVien = @maHocVien and d.MaLop = l.MaLop

create Proc USPxoaHocVien
@maHocVien int
as
begin 
	declare @count int;
	set @count = (select count(*) from DangKy where DangKy.MaHocVien = @maHocVien)
	if @count > 0
		THROW 50000, N'Còn lớp liên qua tới học viên', 1;
	else 
		delete HocVien where MaHocVien=@maHocVien
end

create function UF_LoadHocVienByMaHocVien
(@maHocVien int)
returns table 
as 
return 
select * from HocVien where MaHocVien = @maHocVien


create Proc USPthemDangKy
@maHocVien int, @maLop varchar(15), @diem float
as
begin 
	declare @count int;
	set @count = ( select count(*) from DangKy where MaHocVien=@maHocVien and MaLop=@maLop ) 
	if @count > 0
		throw 50000, N'Học viên đã có trong lớp', 1;
	else	
		insert DangKy values(@maHocVien, @maLop, @diem)
end

create proc USPxoaDangKy
@maHocVien int, @maLop varchar(15)
as
begin
	delete DangKy where MaHocVien=@maHocVien and MaLop=@maLop
end

create Proc USPupdateHocVien
@maHocVien int, @ho nvarchar(15), @ten nvarchar(15),
@gioiTinh bit, @ngaySinh datetime , @diaChi nvarchar(100),
@dienThoai varchar(10), @email varchar(50)
as
begin
	update HocVien set Ho=@ho, Ten=@ten, GioiTinh=@gioiTinh,
	NgaySinh=@ngaySinh, DiaChi=@diaChi, 
	DienThoai=@dienThoai, Email=@email
	where MaHocVien=@maHocVien 
end

create Proc USPaddHocVien
@ho nvarchar(15), @ten nvarchar(15),
@ngaySinh Date, @gioiTinh bit, @diaChi nvarchar(100),
@dienThoai varchar(10), @email varchar(50)
as
begin 
	Insert HocVien values(@ho, @ten, @ngaySinh, @gioiTinh, @diaChi, @dienThoai, @email)
end

create function UFviewTenHocVienbyLop
(@maLop varchar(15))
returns table 
as
return 
	select HocVien.MaHocVien, HocVien.Ho, HocVien.Ten from Lop
	inner join DangKy on Lop.MaLop=DangKy.MaLop
	inner join HocVien on DangKy.MaHocVien=HocVien.MaHocVien
	where Lop.MaLop = @maLop


create proc USPthemLop
@maLop varchar(15), @tenLop varchar(30), @maGiaoVien int, 
@ngayBatDau date, @ngayKetThuc date, @maNgoaiNgu varchar(3),
@diaDiem nvarchar(50), @thoiGian nvarchar(50), @ghiChu nvarchar(100)
as
begin 
	declare @count int
	set @count = ( select count(*) from Lop where MaLop = @maLop )
	if @count > 0 
		throw 50000, N'Đã có mã lớp này ', 1
	else
		insert Lop values(@maLop, @tenLop, @maGiaoVien, @ngayBatDau, @ngayKetThuc, @maNgoaiNgu, @diaDiem, @thoiGian, @ghiChu)
end	

create proc USPupdateLop
@maLop varchar(15), @tenLop varchar(30), @maGiaoVien int, 
@ngayBatDau date, @ngayKetThuc date, @maNgoaiNgu varchar(3),
@diaDiem nvarchar(50), @thoiGian nvarchar(50), @ghiChu nvarchar(100)
as
begin 
	declare @count int
	set @count = ( select count(*) from Lop where MaLop = @maLop )
	if @count = 0 
		throw 50000, N'lớp không tồn tại ', 1
	else
		update Lop set TenLop=@tenLop, MaGiaoVien=@maGiaoVien,
		NgayBatDau=@ngayBatDau, NgayKetThuc=@ngayKetThuc, MaNgoaiNgu=@maNgoaiNgu,
		DiaDiem=@diaDiem, ThoiGian=@thoiGian, GhiChu=@ghiChu
		where MaLop=@maLop
end

create proc USPxoaLop
@maLop varchar(15)
as
begin 
	declare @count int
	set @count = ( select count(*) from DangKy where MaLop=@maLop )
	if @count > 0 
		throw 50000, N'Còn liên kết với bảng đăng ký ', 1
	else
		delete Lop where MaLop=@maLop
end

create function UFtimGiaoVienByMaBangCap
(@maBangCap varchar(3))
RETURNS TABLE
AS
	RETURN 
	SELECT GiaoVien.MaGiaoVien,Ho,Ten FROM TrinhDoGiaoVien
	INNER JOIN GiaoVien 
	ON TrinhDoGiaoVien.MaGiaoVien=GiaoVien.MaGiaoVien
	WHERE MaBangCap=@maBangCap

create FUNCTION UFtimBangCap
(@maBangCap varchar(30), @tenBangCap nvarchar(30) )
RETURNS TABLE 
AS 
	RETURN 
	SELECT * FROM BangCap
	WHERE (@maBangCap = ' ' OR MaBangCap = @maBangCap)
	AND (@tenBangCap = ' ' OR TenBangCap LIKE '%' + @tenBangCap + '%')
	
create PROC USPthemBangCap
@maBangCap varchar(3), @tenBangCap nvarchar(30)
AS 
BEGIN
	DECLARE @count int;
	SET @count = (SELECT COUNT(*) FROM BangCap WHERE MaBangCap=@maBangCap)
	IF @count > 0
		THROW 50000, N'Trùng mã bằng cấp',1;
	ELSE BEGIN 
		SET @count = (SELECT COUNT(*) FROM BangCap WHERE TenBangCap=@tenBangCap)
		IF @count > 0
			THROW 50000, N'Trùng tên bằng cấp',1;
		ELSE 
			INSERT BangCap VALUES(@maBangCap, @tenBangCap)
		END 
END			

create PROC USPxoaBangCap
@maBangCap varchar(3)
AS 
BEGIN 
	DECLARE @count int;
	SET @count = (SELECT COUNT(*) FROM TrinhDoGiaoVien WHERE TrinhDoGiaoVien.MaBangCap=@maBangCap)
	IF @count > 0
		THROW 50000, N'Còn lớp liên qua tới bằng cấp', 1;
	ELSE 
		DELETE BangCap WHERE MaBangCap=@maBangCap
end	

create PROC USPupdateBangCap
@maBangCap varchar(3), @tenBangCap nvarchar(30)
AS
BEGIN
    DECLARE @count int;
	SET @count = (SELECT COUNT(*) FROM BangCap WHERE MaBangCap<>@maBangCap AND TenBangCap=@tenBangCap)
	IF @count > 0
		THROW 50000, N'Trùng tên bằng cấp', 1;
	ELSE
		UPDATE BangCap SET TenBangCap=@tenBangCap where MaBangCap=@maBangCap
END

create FUNCTION UFtimNgoaingu
( @maNgoaiNgu VARCHAR(3), @tenNgoaiNgu NVARCHAR(30) )
RETURNS TABLE
AS 
    RETURN SELECT * FROM NgoaiNgu
	WHERE (@maNgoaiNgu = ' ' OR MaNgoaiNgu = @maNgoaiNgu)
	AND (@tenNgoaiNgu = ' ' OR TenNgoaiNgu LIKE '%' + @tenNgoaiNgu + '%')

create function UFtimGiaoVienByMaNgoaiNgu
(@maNgoaiNgu varchar(3))
RETURNS TABLE
AS
	RETURN 
	SELECT GiaoVien.MaGiaoVien,Ho,Ten FROM TrinhDoGiaoVien
	INNER JOIN GiaoVien 
	ON TrinhDoGiaoVien.MaGiaoVien=GiaoVien.MaGiaoVien
	WHERE MaNgoaiNgu=@maNgoaiNgu

create PROC USPxoaNgoaiNgu
@maNgoaiNgu VARCHAR(3)
AS 
BEGIN
	DECLARE @count INT;
	SET @count = (SELECT COUNT(*) FROM Lop WHERE MaNgoaiNgu = @maNgoaiNgu)
	IF @count > 0
		THROW 50000, N'Còn lớp liên qua tới ngoại ngữ', 1;
	ELSE BEGIN 
		SET @count = (SELECT COUNT(*) FROM dbo.TrinhDoGiaoVien WHERE MaNgoaiNgu = @maNgoaiNgu)
		IF @count > 0 
			THROW 50000, N'Còn lớp liên qua tới ngoại ngữ', 1;
		ELSE 
			DELETE dbo.NgoaiNgu WHERE MaNgoaiNgu = @maNgoaiNgu
		end
END

create proc USPupdateNgoaiNgu
@maNgoaiNgu varchar(3), @tenNgoaiNgu nvarchar(30)
AS 
BEGIN 
	DECLARE @count INT;
	SET @count = (SELECT COUNT(*) FROM dbo.NgoaiNgu WHERE MaNgoaiNgu<>@maNgoaiNgu AND TenNgoaiNgu=@tenNgoaiNgu)
	IF @count > 0
		THROW 50000, N'Trùng tên ngoại ngữ', 1;
	ELSE 
		UPDATE dbo.NgoaiNgu SET TenNgoaiNgu=@tenNgoaiNgu WHERE MaNgoaiNgu=@maNgoaiNgu
END

create proc USPthemNguoiDung
@tenDangNhap varchar(30), @matKhau varchar(128),
@trangThai bit
as
begin	
	declare @count int;
	set @count = ( select count(*) from NguoiDung where TenDangNhap = @tenDangNhap )
	if @count > 0
		throw 50000, N'Tên người dùng đã tồn tại', 1;
	else
		insert NguoiDung values (@tenDangNhap, @matKhau, @trangThai)
end

create function UFviewPhanQuyenByTenDangNhap
(@tenDangNhap varchar(30))
returns table 
as
	return 
	select TenChucNang from NguoiDung 
	inner join PhanQuyen on NguoiDung.TenDangNhap = PhanQuyen.TenDangNhap
	inner join ChucNang on PhanQuyen.MaChucNang = ChucNang.MaChucNang
	where NguoiDung.TenDangNhap = @tenDangNhap

create proc USPupdateNguoiDung
@tenDangNhap varchar(30), @matKhau varchar(128),
@trangThai bit
as 
begin
	declare @count int
	set @count = ( select count(*) from NguoiDung where TenDangNhap=@tenDangNhap )
	if @count = 0
		throw 50000, N'Tên đăng nhập không tồn tại ', 1;
	else
		update NguoiDung set MatKhau=@matKhau, TrangThai=@trangThai where TenDangNhap=@tenDangNhap
end

create proc USPxoaNguoiDung
@tenDangNhap varchar(30)
as 
begin
	declare @count int
	set @count = ( select count(*) from PhanQuyen where TenDangNhap=@tenDangNhap )
	if @count > 0
		throw 50000, N'Còn liên quan đến dữ liệu bảng phân quyền ', 1;
	else
		delete NguoiDung where TenDangNhap = @tenDangNhap
end

create proc USPthemTenChucNangToNguoiDung
@tenDangNhap varchar(30), @tenChucNang varchar(50)
as 
begin 
	declare @count int
	set @count = ( select COUNT(*) from NguoiDung
					inner join PhanQuyen on NguoiDung.TenDangNhap=PhanQuyen.TenDangNhap
					inner join ChucNang on PhanQuyen.MaChucNang=ChucNang.MaChucNang 
					where NguoiDung.TenDangNhap=@tenDangNhap AND ChucNang.TenChucNang=@tenChucNang )
	if @count > 0
		throw 50000, N'Chức năng này đã có sẵn',1
	else
		declare @maChucNang int
		set @maChucNang = ( select MaChucNang from ChucNang where TenChucNang=@tenChucNang )
		insert PhanQuyen values (@tenDangNhap, @maChucNang)
end 

create proc USPxoaTenChucNangToNguoiDung
@tenDangNhap varchar(30), @tenChucNang varchar(50)
as 
begin 
	declare @count int
	set @count = ( select COUNT(*) from NguoiDung
					inner join PhanQuyen on NguoiDung.TenDangNhap=PhanQuyen.TenDangNhap
					inner join ChucNang on PhanQuyen.MaChucNang=ChucNang.MaChucNang 
					where NguoiDung.TenDangNhap=@tenDangNhap AND ChucNang.TenChucNang=@tenChucNang )
	if @count = 0
		throw 50000, N'Không có chức năng này bên trong tên người dùng trên',1
	else
		declare @maChucNang int
		set @maChucNang = ( select MaChucNang from ChucNang where TenChucNang=@tenChucNang )
		delete PhanQuyen where TenDangNhap=@tenDangNhap and MaChucNang=@maChucNang
end

create function UF_ViewtenDangNhapByMaChucNang
(@maChucNang int)
returns table 
as
	return 
	select NguoiDung.TenDangNhap from NguoiDung 
	inner join PhanQuyen on NguoiDung.TenDangNhap = PhanQuyen.TenDangNhap
	inner join ChucNang on PhanQuyen.MaChucNang = ChucNang.MaChucNang
	where ChucNang.MaChucNang = @maChucNang

create proc USPthemChucNang
@maChucNang int, @TenChucNang varchar(30), @trangThai bit
as
begin	
	declare @count int;
	set @count = ( select count(*) from ChucNang where MaChucNang = @maChucNang )
	if @count > 0
		throw 50000, N'Đã tồn tại chức năng này ', 1;
	else
		insert ChucNang values (@maChucNang, @TenChucNang, @trangThai)
end

create proc USPupdateChucNang
@maChucNang int, @TenChucNang varchar(30), @trangThai bit
as 
begin
	declare @count int;
	set @count = ( select count(*) from ChucNang where MaChucNang = @maChucNang )
	if @count = 0
		throw 50000, N'Tên đăng nhập này không tồn tại ', 1;
	else
		update ChucNang set TenChucNang=@TenChucNang, TrangThai=@trangThai where MaChucNang=@maChucNang
end

create proc USPxoaChucNang
@maChucNang varchar(30)
as 
begin
	declare @count int
	set @count = ( select count(*) from PhanQuyen where MaChucNang=@maChucNang )
	if @count > 0
		throw 50000, N'Còn liên quan đến dữ liệu bảng phân quyền ', 1;
	else
		delete ChucNang where MaChucNang = @maChucNang
end

CREATE FUNCTION ufLayPhanQuyen(@tenDangNhap VARCHAR (30))
RETURNS TABLE 
AS 
	RETURN (SELECT TenChucNang FROM ChucNang
	INNER JOIN PhanQuyen ON PhanQuyen.MaChucNang=ChucNang.MaChucNang
	WHERE TenDangNhap=@tenDangNhap)

create procedure spdangNhap @tenDangNhap varchar(30) , @matkhau varchar(128)
As BEGIN 
	DeCLARE @dem INT;
	SET @dem =( SELECT COUNT (*) FROM NguoiDung WHERE TenDangNhap = @tenDangNhap);
	IF @dem>0 BEGIN 
		DECLARE @matKhauDung VARCHAR (128);
		SET @matKhauDung= (SELECT MatKhau From NguoiDung WHERE TenDangNhap=@tenDangNhap );
		IF @matKhauDung<> @matKhau
		THROW 50000, N'Sai mật khẩu',1;
	ELSE BEGIN 
		DECLARE @trangThai BIT ;
		SET @trangThai =(SELECT TrangThai FROM NguoiDung
		WHERE TenDangNhap =@tenDangNhap);
		IF @trangThai = 0
			THROW 50001 , 'Người dùng đã bị khoá ',1;
		END
	END
	ELSE 
		THROW 50002,N'Tên đăng nhập không tồn tại ',1;
END

CREATE TRIGGER tgThemNgoaiNgu
ON NgoaiNgu
FOR INSERT
AS BEGIN
	DECLARE @tenDangNhap VARCHAR(30);
	DECLARE @tenNgoaiNgu NVARCHAR(30);
	SET @tenDangNhap = (SELECT NguoiSua FROM INSERTED);
	SET @tenNgoaiNgu = (SELECT TenNgoaiNgu FROM INSERTED);
	INSERT NhatKy(TenDangNhap,ThoiDiem,NoiDung) 
	VALUES(@tenDangNhap,GETDATE(),N'Thêm dữ liệu NgoaiNgu: ' + @tenNgoaiNgu);
END

CREATE TRIGGER tgSuaNgoaiNgu
ON NgoaiNgu
FOR UPDATE
AS BEGIN
	DECLARE @tenDangNhap VARCHAR(30);
	DECLARE @tenNgoaiNguCu NVARCHAR(30);
	DECLARE @tenNgoaiNguMoi NVARCHAR(30);
	DECLARE @noiDung NVARCHAR(200);
	SET @noiDung = N'Sửa dữ liệu NgoaiNgu: ';
	SET @tenDangNhap = (SELECT NguoiSua FROM INSERTED);
	SET @tenNgoaiNguCu = (SELECT TenNgoaiNgu FROM DELETED);
	SET @tenNgoaiNguMoi = (SELECT TenNgoaiNgu FROM INSERTED);
	IF @tenNgoaiNguCu <> @tenNgoaiNguMoi
		SET @noiDung = @noiDung + N'Tên ngoại ngữ ' + @tenNgoaiNguCu
		+ ' => ' + @tenNgoaiNguMoi + '. ';
	INSERT NhatKy(TenDangNhap,ThoiDiem,NoiDung) 
	VALUES(@tenDangNhap,GETDATE(),@noiDung);
END


