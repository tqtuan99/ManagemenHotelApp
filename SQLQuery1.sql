create table KHACHHANG(
	idkhachhang int Identity(123,1) not null constraint pk_khachhang primary key,
	hotenkh nvarchar(50) not null,
	gioitinh nvarchar(10) not null,
	ngaysinh date,
	socccd nvarchar(30) not null unique,
	sodienthoai nvarchar(20) not null,
	quoctich nvarchar(30),
	ghichu nvarchar(100)
)

create table NHANVIEN(
	idnhanvien int Identity(123,1) not null constraint pk_nhanvien primary key,
	idchucvu int not null,
	hotennv nvarchar(100) not null,
	gioitinh nvarchar(10) not null,
	socccd nvarchar(30) not null unique,
	sodienthoai nvarchar(20) not null,
	ngaysinh date not null,
	ngayvaolam date not null,
	ngaynghiviec date,
	diachi nvarchar(100),
	email nvarchar(100),
	hesoluong int not null,
	trangthai bit default 1,
	ghichu nvarchar(200)
)

create table PHONG(
	idphong int Identity(1,1) not null,
	idloaiphong int not null,
	tang int not null,
	tenphong nvarchar(20) not null,
	dongia float not null,
	mucgiamgia float default 0,
	sogiuong int,
	songuoi int,
	trangthai bit default 1,
	ghichu nvarchar(100)
)

create table CT_HOADONPHONG (
	idhoadon int not null,
	idphong int not null,
)

create table HOADONPHONG (
	idhoadon int Identity(1,1) not null,
	idkhachhang int not null,
	idnhanvien int not null,
	ngaytao date not null,
	ngaythanhtoan date,
	ghichu nvarchar(100),
)

create table LOAIPHONG(
	idloaiphong int Identity(1,1) not null,
	tenloaiphong nvarchar(50) not null,
	ghichu nvarchar(100)
)

create table TAIKHOAN (
	idtaikhoan int Identity(100,1) not null,
	idnhanvien int not null unique,
	username nvarchar(50) not null,
	pass nvarchar(50) default '123'
)

create table DICHVU(
	iddichvu int Identity(1,1) not null,
	tendichvu nvarchar(100) not null,
	giadichvu float not null,
	soluong int not null,
	trangthai bit default 1 not null,
	mota nvarchar(max),
	mucgiamgia float default 0,
	ghichu nvarchar(100)
)
create table CT_HOADONDICHVU(
	idhoadon int not null,
	iddichvu int not null,
	thoigianyeucau datetime not null,
	soluong int not null
)
create table HOADONDICHVU(
	idhoadon int identity(1,1) not null,
	idnhanvien int not null,
	idkhachhang int not null,
	ngaythanhtoan date ,
	ngaytao date not null,
	ghichu nvarchar(200)
)
create table LOAITHUCPHAM(
	idloaithucpham int identity(1,1) not null,
	tenloai nvarchar(100),
)
create table THUCPHAM(
	idthucpham int identity (1,1) not null,
	idloaithucpham int not null,
	tenthucpham nvarchar(100) not null,
	soluong int not null,
	gianhap float not null,
	ghichu nvarchar(200)
)
create table HOADONTHUCPHAM (
	idhoadon int identity(1,1) not null,
	idnhanvien int not null,
	idkhachhang int not null,
	ngaytao date not null,
	ngaythanhtoan date,
	ghichu nvarchar(200)
)
create table CT_HOADONTHUCPHAM(
	idhoadon int not null,
	idthucpham int not null,
	giaban float not null,
	soluong int not null
)