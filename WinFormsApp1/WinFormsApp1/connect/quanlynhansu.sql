----------------i. tạo database
create database	quanLyNhanSuCSharp

on primary
(
	name='quanLyNhanSuCSharp_prim',
	filename='D:\SV\Hoc_Ki_7\CSharp\DoAn\databaseCSharp\quanLyNhanSuCSharp_prim.mdf',
	size=10MB,
	filegrowth=10%,
	maxsize=30MB
)

log on 
(
	name='quanLyNhanSuCSharp_log',
	filename='D:\SV\Hoc_Ki_7\CSharp\DoAn\databaseCSharp\quanLyNhanSuCSharp_log.ldf',
	size=3MB,
	filegrowth=20%,
	maxsize=18MB
)

use quanLyNhanSuCSharp
go

-------------------------------------------------------------------------------
--------------- ii. tạo các bảng và khóa chính của nó

-- 1. tạo bảng quyền (quyền của tài khoản khi truy cập vào hệ thống: admin, nhân viên bình thường và quản lý nhân sự)
-- trạng thái (1) hoạt động, (0) bị khóa, (-1) bị xóa
create table quyen (
    maQuyen nvarchar(10) not null,
    tenQuyen nvarchar(100) not null unique,
    moTa nvarchar(200),
    trangThai int not null
);
go

alter table quyen add constraint pk_quyen primary key (maQuyen)
go

insert into quyen(maQuyen, tenQuyen, moTa, trangThai) values ('Q001', 'admin', N'quyền của admin', '1');
insert into quyen(maQuyen, tenQuyen, moTa, trangThai) values ('Q002', 'nhanvien', N'nhân viên bình thường', '1');
insert into quyen(maQuyen, tenQuyen, moTa, trangThai) values ('Q003', 'quanlynhansu', N'quản lý nhân sự', '1');
go

-- 2. tạo bảng tài khoản (mỗi nhân viên tương ứng khi được tuyển dụng, hệ thống tự tạo tài khoản mặc định cho nhân viên đó)
-- trạng thái (1) hoạt động, (0) bị khóa, (-1) bị xóa
create table taiKhoan (
    maTaiKhoan nvarchar(10) not null,
    tenTaiKhoan nvarchar(100) not null unique,
    matKhau nvarchar(20) not null,
    maNhanVien nvarchar(10) not null, -- khóa ngoại
    maQuyen nvarchar(10) not null, -- khóa ngoại
    trangThai int not null
);
go

alter table taiKhoan add constraint pk_taiKhoan primary key (maTaiKhoan)
go

-- 3. tạo bảng phúc lợi (bao gồm bảo hiểm, các khoản trợ cấp,...)
-- trạng thái (1) hoạt động, (0) bị khóa, (-1) bị xóa
create table phucLoi (
    maPhucLoi nvarchar(10) not null,
    tenPhucLoi nvarchar(100) not null unique,
	moTa nvarchar(200),
    giaTriPhucLoi int default(0),
    trangThai int not null
);
go

alter table phucLoi add constraint pk_phucLoi primary key (maPhucLoi)
go

-- 4. tạo bảng khen thưởng
-- trạng thái (1) được tạo nhưng chưa khen thưởng, (0) đã khen thưởng, (-1) bị hủy
create table khenThuong (
    maKhenThuong nvarchar(10) not null,
    maNhanVien nvarchar(10) null, -- khóa ngoại
    loaiKhenThuong nvarchar(100) not null,
    chiTietKhenThuong nvarchar(200),
	giaTriKhenThuong int default(0),
    ngayKhenThuong date null,
    trangThai int not null
);
go

alter table khenThuong add constraint pk_khenThuong primary key (maKhenThuong)
go

-- 5. tạo bảng hồ sơ kỷ luật (ghi lại các vi phạm của nhân viên)
-- hình thức kỷ luật (cảnh cáo, khiển trách, trừ lương, bỏ khen thưởng, sa thải,...)
-- trạng thái (1), (-1) hủy bỏ vi phạm
create table hoSoKyLuat (
    maHoSoKyLuat nvarchar(10) not null,
    maNhanVien nvarchar(10) not null, -- khóa ngoại
	chiTietViPham nvarchar(200) not null,
    hinhThucKyLuat nvarchar(100),
	tacDongKyLuat nvarchar(100),
	bienPhapKhacPhuc nvarchar(100),
    ngayGhiNhan date not null,
	mucPhat int default(0),
	thoiGianApDung date,
    trangThai int
);
go

alter table hoSoKyLuat add constraint pk_hoSoKyLuat primary key (maHoSoKyLuat)
go

-- 6. tạo bảng kỳ tuyển dụng
-- trạng thái (1), (0) bị khóa (dời lịch tuyển dụng...), (-1) hủy bỏ
create table kyTuyenDung (
    maKyTuyenDung nvarchar(10) not null,
    noiDung nvarchar(400) not null,
    ngayBatDau date not null,
    ngayKetThuc date not null,
    maQuanLy nvarchar(10) not null, -- khóa ngoại
    trangThai int not null
);
go

alter table kyTuyenDung add constraint pk_kyTuyenDung primary key (maKyTuyenDung)
go

-- 7. tạo bảng hồ sơ tuyển dụng (khi nhân viên được xét duyệt thì tự thêm nhân viên đó vào cơ sở dữ liệu)
-- trạng thái (1) chờ được duyệt, (0) duyệt, (-1) bị từ chối
create table hoSoTuyenDung (
    maHoSoTuyenDung nvarchar(10) not null,
    hoTen nvarchar(100) not null,
    ngaySinh date not null,
    gioiTinh nvarchar(10) not null,
    diaChi nvarchar(100) not null,
    email nvarchar(100) not null,
    sdt nvarchar(12) not null,
    trinhDo nvarchar(40) not null,
    moTaBangCap nvarchar(200),
    kyTuyenDung nvarchar(10) not null, -- khóa ngoại
    trangThai int not null
);
go

alter table hoSoTuyenDung add constraint pk_hoSoTuyenDung primary key (maHoSoTuyenDung)
go
alter table hoSoTuyenDung add constraint ck_gioiTinh_hoSoTuyenDung check (gioiTinh in (N'Nam', N'Nữ'))
go

-- 8. tạo bảng nhân viên
-- trạng thái (1) hoạt động, (-1) bị xóa/sa thải
create table nhanVien (
    maNhanVien nvarchar(10) not null,
    hoTen nvarchar(100) not null,
    ngaySinh date not null,
    gioiTinh nvarchar(10) not null,
    diaChi nvarchar(100) not null,
    email nvarchar(100) not null,
    sdt nvarchar(12) not null,
    nguoiQuanLy nvarchar(10) null, -- khóa ngoại
    phongBan nvarchar(10) null, -- khóa ngoại
    chucVu nvarchar(10) not null, -- khóa ngoại
    hoSoGioiThieu nvarchar(10) null, -- khóa ngoại
    trangThai int not null
);
go

alter table nhanVien add constraint pk_nhanVien primary key (maNhanVien)
go
alter table nhanVien add constraint ck_gioiTinh_nhanVien check (gioiTinh in (N'Nam', N'Nữ'))
go

-- 9. tạo bảng quản lý nhân sự
-- trạng thái (1), (0) bị đình chỉ, (-1) chuyển công tác
create table quanLyNhanSu (
    maQuanLyNhanSu nvarchar(10) not null,
    trangThai int not null
);
go

alter table quanLyNhanSu add constraint pk_quanLyNhanSu primary key (maQuanLyNhanSu)
go

-- 10. tạo bảng thông báo
-- trạng thái (1) hoạt động, (0) bị khóa, (-1) bị xóa
create table bangThongBao (
    maThongBao nvarchar(10) not null,
    noiDung nvarchar(400) not null,
    nguoiBanHanh nvarchar(10) not null, -- khóa ngoại
    ngayBanHanh date not null,
    trangThai int not null
);
go

alter table bangThongBao add constraint pk_bangThongBao primary key (maThongBao)
go

-- 11. tạo bảng phòng ban
-- trạng thái (1) hoạt động, (0) bị khóa, (-1) bị xóa
create table phongBan (
    maPhongBan nvarchar(10) not null,
    tenPhongBan nvarchar(100) not null unique,
    moTa nvarchar(400),
    truongPhong nvarchar(10) null, -- khóa ngoại
    trangThai int not null
);
go

alter table phongBan add constraint pk_phongBan primary key (maPhongBan)
go

-- 12. tạo bảng chức vụ
-- trạng thái (1) hoạt động, (0) bị khóa, (-1) bị xóa
create table chucVu (
    maChucVu nvarchar(10) not null,
    tenChucVu nvarchar(100) not null unique,
    moTa nvarchar(400),
    luongCoBan int default(5000000),
    phongBan nvarchar(10) null, -- khóa ngoại
    trangThai int not null
);
go

alter table chucVu add constraint pk_chucVu primary key (maChucVu)
go

-- 13. tạo bảng dự án
-- trạng thái (1) hoạt động, (0) bị khóa/đã hoàn thành, (-1) bị xóa/hủy
create table duAn (
    maDuAn nvarchar(10) not null,
    tenDuAn nvarchar(100) not null,
    moTa nvarchar(200),
    ngayBatDau date not null,
    ngayKetThuc date not null,
    quanLyDuAn nvarchar(10) not null, -- khóa ngoại
    phongBanPhuTrach nvarchar(10) not null, -- khóa ngoại
    trangThai int
);
go

alter table duAn add constraint pk_duAn primary key (maDuAn)
go

-- Thêm 1 phòng ban nhân sự
INSERT INTO PhongBan (MaPhongBan, TenPhongBan, MoTa, TruongPhong, TrangThai) 
VALUES ('PB001', N'phòng HR', N'phòng nhân sự', NULL, 1);
GO

-- Thêm 1 phòng ban kế toán
INSERT INTO PhongBan (MaPhongBan, TenPhongBan, MoTa, TruongPhong, TrangThai) 
VALUES ('PB002', N'phòng kế toán', N'phòng kế toán', NULL, 1);
GO

-- Thêm 1 chức vụ trong phòng ban nhân sự
INSERT INTO ChucVu (MaChucVu, TenChucVu, MoTa, LuongCoBan, PhongBan, TrangThai) 
VALUES ('CV001', N'nhân viên nhân sự tổng hợp', N'tuyển dụng, đào tạo', '6000000', 'PB001', 1);
GO

-- Thêm 2 chức vụ trong phòng kế toán
INSERT INTO ChucVu (MaChucVu, TenChucVu, MoTa, LuongCoBan, PhongBan, TrangThai) 
VALUES ('CV002', N'kế toán tổng hợp', N'tuyển dụng, đào tạo', '6000000', 'PB001', 1);
GO

INSERT INTO ChucVu (MaChucVu, TenChucVu, MoTa, LuongCoBan, PhongBan, TrangThai) 
VALUES ('CV003', N'kế toán công nợ', N'tuyển dụng, đào tạo', '6000000', 'PB001', 1);
GO

-- Thêm 1 nhân viên phòng nhân sự
INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, GioiTinh, DiaChi, Email, SDT, NguoiQuanLy, PhongBan, ChucVu, HoSoGioiThieu, TrangThai)
VALUES ('NV00001', N'lê minh nguyệt', '2002-02-02', N'nữ', N'tp.hcm', 'minhnguyetmongmoj97@gmail.com', '0912345678', NULL, 'PB001', 'CV001', NULL, 1);
GO

-- Thêm tài khoản cho chị nguyệt
INSERT INTO TaiKhoan (MaTaiKhoan, TenTaiKhoan, MatKhau, MaNhanVien, MaQuyen, TrangThai) 
VALUES ('TK00001', 'chinguyetxinhgai', 'modomdomj97', 'NV00001', 'Q003', 1);
GO

-- Thêm chị quản lý lê minh nguyệt
INSERT INTO QuanLyNhanSu (MaQuanLyNhanSu, TrangThai) 
VALUES ('NV00001', 1);
GO

-- Thêm 1 kỳ tuyển dụng
INSERT INTO KyTuyenDung (MaKyTuyenDung, NoiDung, NgayBatDau, NgayKetThuc, MaQuanLy, TrangThai) 
VALUES ('TD001', N'tuyển kế toán', '2024-12-12', '2025-11-11', 'NV00001', 1);
GO

-- Thêm 3 hồ sơ tuyển dụng
INSERT INTO HoSoTuyenDung (MaHoSoTuyenDung, HoTen, NgaySinh, GioiTinh, DiaChi, Email, SDT, TrinhDo, MoTaBangCap, KyTuyenDung, TrangThai)
VALUES
('HS00001', N'nguyễn văn lê', '1999-01-01', N'nam', N'tp.hcm', 'avannguyen@gmail.com', '0931245678', N'đại học', NULL, 'TD001', 0),
('HS00002', N'nguyễn văn minh', '1998-01-01', N'nam', N'tp.hcm', 'nguyetthuc@gmail.com', '0987654321', N'đại học', NULL, 'TD001', 0),
('HS00003', N'nguyễn văn nguyệt', '1997-01-01', N'nam', N'tp.hcm', 'minhminh@gmail.com', '0931245687', N'đại học', NULL, 'TD001', 0);
GO

-- Thêm 3 nhân viên
INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, GioiTinh, DiaChi, Email, SDT, NguoiQuanLy, PhongBan, ChucVu, HoSoGioiThieu, TrangThai)
VALUES
('NV00002', N'nguyễn văn lê', '1999-01-01', N'nam', N'tp.hcm', 'avannguyen@gmail.com', '0931245678', 'NV00001', 'PB002', 'CV002', 'HS00001', 1),
('NV00003', N'nguyễn văn minh', '1998-01-01', N'nam', N'tp.hcm', 'nguyetthuc@gmail.com', '0987654321', 'NV00001', 'PB002', 'CV002', 'HS00002', 1),
('NV00004', N'nguyễn văn nguyệt', '1997-01-01', N'nam', N'tp.hcm', 'minhminh@gmail.com', '0931245687', 'NV00001', 'PB002', 'CV003', 'HS00003', 1);
GO

-- Thêm dữ liệu cho bảng tài khoản
INSERT INTO TaiKhoan (MaTaiKhoan, TenTaiKhoan, MatKhau, MaNhanVien, MaQuyen, TrangThai)
VALUES 
('TK00002', 'vanle', '123456', 'NV00002', 'Q001', 1),
('TK00003', 'minhnguyenvan', 'abcdef', 'NV00003', 'Q001', 1),
('TK00004', 'nguyetnguyen', 'password', 'NV00004', 'Q001', 1);
GO


use QuanLyNhanSuCSharp
go

-- Thêm 1 phòng ban nhân sự
INSERT INTO PhongBan (maPhongBan, tenPhongBan, moTa, truongPhong, trangThai) 
VALUES ('PB001', N'Phòng HR', N'Phòng nhân sự', NULL, 1);
go

-- Thêm 1 phòng ban kế toán
INSERT INTO PhongBan (maPhongBan, tenPhongBan, moTa, truongPhong, trangThai) 
VALUES ('PB002', N'Phòng kế toán', N'Phòng kế toán', NULL, 1);
go

-- Thêm 1 chức vụ trong phòng ban nhân sự
INSERT INTO ChucVu (maChucVu, tenChucVu, moTa, luongCoBan, phongBan, trangThai) 
VALUES ('CV001', N'Nhân viên nhân sự tổng hợp', N'Tuyển dụng, Đào tạo', '6000000', 'PB001', 1);
go

-- Thêm 2 chức vụ trong phòng kế toán
INSERT INTO ChucVu (maChucVu, tenChucVu, moTa, luongCoBan, phongBan, trangThai) 
VALUES ('CV002', N'Kế toán tổng hợp', N'Tuyển dụng, Đào tạo', '6000000', 'PB001', 1);
go

INSERT INTO ChucVu (maChucVu, tenChucVu, moTa, luongCoBan, phongBan, trangThai) 
VALUES ('CV003', N'Kế toán công nợ', N'Tuyển dụng, Đào tạo', '6000000', 'PB001', 1);
go

-- Thêm 1 nhân viên phòng nhân sự
INSERT INTO NhanVien (maNhanVien, hoTen, ngaySinh, gioiTinh, diaChi, email, sdt, nguoiQuanLy, phongBan, chucVu, hoSoGioiThieu, trangThai)
VALUES ('NV00001', N'Lê Minh Nguyệt', '2002-02-02', N'Nữ', N'TP.HCM', 'minhnguyetmongmoJ97@gmail.com', '0912345678', NULL, 'PB001', 'CV001', NULL, 1);
go

-- Thêm tài khoản cho chị Nguyệt
INSERT INTO TaiKhoan (maTaiKhoan, tenTaiKhoan, matKhau, maNhanVien, maQuyen, trangThai) 
VALUES ('TK00001', 'chiNguyetxinhgai', 'modomdomJ97', 'NV00001', 'Q003', 1);
go

-- Thêm chị quản lý Lê Minh Nguyệt
INSERT INTO QuanLyNhanSu (maQuanLyNhanSu, trangThai)
VALUES ('NV00001', 1);
go

-- Thêm 1 kỳ tuyển dụng
INSERT INTO KyTuyenDung (maKyTuyenDung, noiDung, ngayBatDau, ngayKetThuc, maQuanLy, trangThai) 
VALUES ('TD001', N'Tuyển kế toán', '2024-12-12', '2025-11-11', 'NV00001', 1);
go

-- Thêm 3 hồ sơ tuyển dụng
INSERT INTO HoSoTuyenDung (maHoSoTuyenDung, hoTen, ngaySinh, gioiTinh, diaChi, email, sdt, trinhDo, moTaBangCap, kyTuyenDung, trangThai)
VALUES
('HS00001', N'Nguyễn Văn Lê', '1999-01-01', N'Nam', N'TP.HCM', 'avannguyen@gmail.com', '0931245678', N'Đại học', NULL, 'TD001', 0),
('HS00002', N'Nguyễn Văn Minh', '1998-01-01', N'Nam', N'TP.HCM', 'nguyetthuc@gmail.com', '0987654321', N'Đại học', NULL, 'TD001', 0),
('HS00003', N'Nguyễn Văn Nguyệt', '1997-01-01', N'Nam', N'TP.HCM', 'minhminh@gmail.com', '0931245687', N'Đại học', NULL, 'TD001', 0);
go

-- Thêm 3 nhân viên
INSERT INTO NhanVien (maNhanVien, hoTen, ngaySinh, gioiTinh, diaChi, email, sdt, nguoiQuanLy, phongBan, chucVu, hoSoGioiThieu, trangThai)
VALUES
('NV00002', N'Nguyễn Văn Lê', '1999-01-01', N'Nam', N'TP.HCM', 'avannguyen@gmail.com', '0931245678', 'NV00001', 'PB002', 'CV002', 'HS00001', 1),
('NV00003', N'Nguyễn Văn Minh', '1998-01-01', N'Nam', N'TP.HCM', 'nguyetthuc@gmail.com', '0987654321', 'NV00001', 'PB002', 'CV002', 'HS00002', 1),
('NV00004', N'Nguyễn Văn Nguyệt', '1997-01-01', N'Nam', N'TP.HCM', 'minhminh@gmail.com', '0931245687', 'NV00001', 'PB002', 'CV003', 'HS00003', 1);
go

-- Thêm dữ liệu cho bảng tài khoản
INSERT INTO TaiKhoan (maTaiKhoan, tenTaiKhoan, matKhau, maNhanVien, maQuyen, trangThai)
VALUES 
('TK00002', 'vanle', '123456', 'NV00002', 'Q001', 1),
('TK00003', 'minhnguyenvan', 'abcdef', 'NV00003', 'Q001', 1),
('TK00004', 'nguyetnguyen', 'password', 'NV00004', 'Q001', 1);
go
