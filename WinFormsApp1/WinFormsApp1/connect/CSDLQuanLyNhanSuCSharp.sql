-----------------------------------------------------------------------------------
-- chạy từng phần I -> II -> III


----------------I. Tạo database
create database	QuanLyNhanSuCSharp

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

use QuanLyNhanSuCSharp
go

----------------------------------------------------------------------------
--------------- II. Tạo các bảng và khóa chính của nó

-- 1. Tạo bảng quyền (quyền của tài khoản khi truy cập vào hệ thống: admin, nhân viên bình thường và quản lý nhân sự)
-- Trạng thái (1) hoạt động, (0) bị khóa, (-1) bị xóa
CREATE TABLE Quyen (
    MaQuyen NVARCHAR(10) not null,
    TenQuyen NVARCHAR(100) not null unique,
    MoTa NVARCHAR(200),
    TrangThai int not null
);
go

alter table Quyen add constraint pk_Quyen primary key (MaQuyen)
go

insert into Quyen(MaQuyen, TenQuyen, MoTa, TrangThai) values ('Q001', 'admin', N'Quyền của admin', '1');
insert into Quyen(MaQuyen, TenQuyen, MoTa, TrangThai) values ('Q002', 'nhanvien', N'nhân viên bình thường', '1');
insert into Quyen(MaQuyen, TenQuyen, MoTa, TrangThai) values ('Q003', 'quanlynhansu', N'Quản lý nhân sự', '1');
go

-- 2. Tạo bảng tài khoản (mỗi nhân viên tương ứng khi được tuyển dụng, hệ thống tự tạo tài khoản mặc định cho nhân viên đó)
-- Trạng thái (1) hoạt động, (0) bị khóa, (-1) bị xóa
CREATE TABLE TaiKhoan (
    MaTaiKhoan NVARCHAR(10) not null,
    TenTaiKhoan NVARCHAR(100) not null unique,
    MatKhau NVARCHAR(20) not null,
    MaNhanVien NVARCHAR(10) not null, -- khóa ngoại
    MaQuyen NVARCHAR(10) not null, -- khóa ngoại
    TrangThai int not null
);
go

alter table TaiKhoan add constraint pk_TaiKhoan primary key (MaTaiKhoan)
go

-- 3. Tạo bảng phúc lợi (bao gồm bảo hiểm, các khoảng trợ cấp,...)
-- Trạng thái (1) hoạt động, (0) bị khóa, (-1) bị xóa
CREATE TABLE PhucLoi (
    MaPhucLoi NVARCHAR(10) not null,
    TenPhucLoi NVARCHAR(100) not null unique,
	MoTa NVARCHAR(200),
    GiaTriPhucLoi int default(0),
    TrangThai int not null
);
go

alter table PhucLoi add constraint pk_PhucLoi primary key (MaPhucLoi)
go

-- 4. Tạo bảng khen thưởng
-- Trạng thái (1) được tạo nhưng chưa khen thưởng, (0) đã khen thưởng, (-1) bị hủy
CREATE TABLE KhenThuong (
    MaKhenThuong NVARCHAR(10) not null,
    MaNhanVien NVARCHAR(10) null, -- khóa ngoại
    LoaiKhenThuong NVARCHAR(100) not null,
    ChiTietKhenThuong NVARCHAR(200),
	GiaTriKhenThuong int default(0),
    NgayKhenThuong DATE null,
    TrangThai int not null
);
go

alter table KhenThuong add constraint pk_KhenThuong primary key (MaKhenThuong)
go

-- 5. Tạo bảng hồ sơ kỷ luật (ghi lại các vi phạm của nhân viên)
-- hình thức kỷ luật (cảnh cáo, khiển trách, trừ lương, bỏ khen thưởng, sa thải,...)
-- Trạng thái (1), (-1) hủy bỏ vi phạm
CREATE TABLE HoSoKyLuat (
    MaHoSoKyLuat NVARCHAR(10) not null,
    MaNhanVien NVARCHAR(10) not null, -- khóa ngoại
	ChiTietViPham NVARCHAR(200) not null,
    HinhThucKyLuat NVARCHAR(100),
	TacDongkyLuat NVARCHAR(100),
	BienPhapKhacPhuc NVARCHAR(100),
    NgayGhiNhan DATE not null,
	MucPhat int default(0),
	ThoiGianApDung DATE,
    TrangThai int
);
go

alter table HoSoKyLuat add constraint pk_HoSoKyLuat primary key (MaHoSoKyLuat)
go

-- 6. Tạo bảng kỳ tuyển dụng
-- Trạng thái (1), (0) bị khóa(dời lịch tuyển dụng...), (-1) hủy bỏ
CREATE TABLE KyTuyenDung (
	MaKyTuyenDung NVARCHAR(10) not null,
	NoiDung NVARCHAR(400) not null,
	NgayBatDau DATE not null,
	NgayKetThuc DATE not null,
	MaQuanLy NVARCHAR(10) not null, -- khóa ngoại
	TrangThai int not null
);
go

alter table KyTuyenDung add constraint pk_KyTuyenDung primary key (MaKyTuyenDung)
go

-- 7. Tạo bảng hồ sơ tuyển dụng (khi nhân viên được xét duyệt thì tự thêm nhân viên đó vào cơ sở dữ liệu)
-- trình độ
-- Trạng thái (1) chờ được duyệt, (0) duyệt, (-1) bị từ chối
CREATE TABLE HoSoTuyenDung (
	MaHoSoTuyenDung NVARCHAR(10) not null,
	HoTen NVARCHAR(100) not null,
	NgaySinh DATE not null,
	GioiTinh NVARCHAR(10) not null,
	DiaChi NVARCHAR(100) not null,
	Email NVARCHAR(100) not null,
	SDT NVARCHAR(12) not null,
	TrinhDo NVARCHAR(40) not null,
	MoTaBangCap NVARCHAR(200),
	KyTuyenDung NVARCHAR(10) not null, -- khóa ngoại
	TrangThai int not null
);
go

alter table HoSoTuyenDung add constraint pk_HoSoTuyenDung primary key (MaHoSoTuyenDung)
go
alter table HoSoTuyenDung add constraint ck_GioiTinh_HoSoTuyenDung check (GioiTinh in (N'Nam', N'Nữ'))
go

-- 8. Tạo bảng nhân viên
-- Trạng thái (1) hoạt động, (-1) bị xóa/sa thải
CREATE TABLE NhanVien (
	MaNhanVien NVARCHAR(10) not null,
	HoTen NVARCHAR(100) not null,
	NgaySinh DATE not null,
	GioiTinh NVARCHAR(10) not null,
	DiaChi NVARCHAR(100) not null,
	Email NVARCHAR(100) not null,
	SDT NVARCHAR(12) not null,
	NguoiQuanLy NVARCHAR(10) null, -- khóa ngoại
	PhongBan NVARCHAR(10) null, -- khóa ngoại
	ChucVu NVARCHAR(10) not null, -- khóa ngoại
	HoSoGioiThieu NVARCHAR(10) null, -- khóa ngoại
	TrangThai int not null
);
go

alter table NhanVien add constraint pk_NhanVien primary key (MaNhanVien)
go
alter table NhanVien add constraint ck_GioiTinh_NhanVien check (GioiTinh in (N'Nam', N'Nữ'))
go

-- 9. Tạo bảng quản lý nhân sự
-- Trang thái (1), (0) bị đình chỉ, (-1) chuyển công tác 
CREATE TABLE QuanLyNhanSu (
	MaQuanLyNhanSu NVARCHAR(10) not null,
	TrangThai int not null,
);
go

alter table QuanLyNhanSu add constraint pk_QuanLyNhanSu primary key (MaQuanLyNhanSu)
go

-- 10. Tạo bảng thông báo
-- Trạng thái (1) hoạt động, (0) bị khóa, (-1) bị xóa
CREATE TABLE BangThongBao (
	MaThongBao NVARCHAR(10) not null,
	NoiDung NVARCHAR(400) not null,
	NguoiBanHanh NVARCHAR(10) not null, -- khóa ngoại
	NgayBanHanh DATE not null,
	TrangThai int not null
);
go

alter table BangThongBao add constraint pk_ThongBao primary key (MaThongBao)
go

-- 11. Tạo bảng phòng ban
-- Trạng thái (1) hoạt động, (0) bị khóa, (-1) bị xóa
CREATE TABLE PhongBan (
	MaPhongBan NVARCHAR(10) not null,
	TenPhongBan NVARCHAR(100) not null unique,
	MoTa NVARCHAR(400),
	TruongPhong NVARCHAR(10) null, -- khóa ngoại
	TrangThai int not null
);
go

alter table PhongBan add constraint pk_PhongBan primary key (MaPhongBan)
go

-- 12. Tạo bảng chức vụ
-- Trạng thái (1) hoạt động, (0) bị khóa, (-1) bị xóa
CREATE TABLE ChucVu (
	MaChucVu NVARCHAR(10) not null,
	TenChucVu NVARCHAR(100) not null unique,
	MoTa NVARCHAR(400),
	LuongCoBan int default(5000000),
	PhongBan NVARCHAR(10) null, -- khóa ngoại
	TrangThai int not null
);
go

alter table ChucVu add constraint pk_ChucVu primary key (MaChucVu)
go

-- 13. Tạo bảng dự án
-- Trạng thái (1) hoạt động, (0) bị khóa/đã hoàn thành, (-1) bị xóa/hủy
CREATE TABLE DuAn (
	MaDuAn NVARCHAR(10) not null,
	TenDuAn NVARCHAR(100) not null,
	MoTa NVARCHAR(200),
	NgayBatDau DATE not null,
	NgayKetThuc DATE not null,
	QuanLyDuAn NVARCHAR(10) not null, -- khóa ngoại
	PhongBanPhuTrach NVARCHAR(10) not null, -- khóa ngoại
	TrangThai int
);

alter table DuAn add constraint pk_DuAn primary key (MaDuAn)
go

-- 14. Tạo bảng chấm công
CREATE TABLE BangChamCong (
	MaBangChamCong NVARCHAR(10) not null,
	ThangNam DATE not null, 
	GioVaoCa TIME not null
);
go

alter table BangChamCong add constraint pk_BangChamCong primary key (MaBangChamCong)
go

-- 15. Tạo bảng lương
CREATE TABLE BangLuong (
	MaNhanVien NVARCHAR(10) not null,
	ThangNam DATE not null,
	PhuCap int default(0),
	KhauTru int default(0),
	LuongThucNhan int default(5000000)
);
go

alter table BangLuong add constraint pk_BangLuong primary key (MaNhanVien, ThangNam)
go

-- 16. Tạo bảng chi tiết nhân viên tham gia phúc lợi
CREATE TABLE ChiTietPhucLoiNhanVien (
	MaPhucLoi NVARCHAR(10) not null,
	MaNhanVien NVARCHAR(10) not null
);
go

alter table ChiTietPhucLoiNhanVien add constraint pk_ChiTietPhucLoiNhanVien primary key (MaPhucLoi, MaNhanVien)
go

-- 17. Tạo bảng chi tiết dự án nhân viên
CREATE TABLE ChiTietDuAnNhanVien (
	MaDuAn NVARCHAR(10) not null,
	MaNhanVien NVARCHAR(10) not null
);
go

alter table ChiTietDuAnNhanVien add constraint pk_ChiTietDuAnNhanVien primary key (MaDuAn, MaNhanVien)
go

-- 18. Tạo bảng chi tiết nhân viên chấm công
-- Trạng thái (1), (0) đi trễ, (-1) vắng có phép, (-2) vắng không phép
CREATE TABLE ChiTietNhanVienChamCong (
	MaBangChamCong NVARCHAR(10) not null,
	MaNhanVien NVARCHAR(10) not null,
	MaQuanLyNhanSu NVARCHAR(10) not null,
	NgayGioChamCong DATETIME not null,
	TrangThai int not null
);
go

alter table ChiTietNhanVienChamCong add constraint pk_ChiTietNhanVienChamCong primary key (MaBangChamCong, MaNhanVien, MaQuanLyNhanSu, NgayGioChamCong)
go

---------------------------------------------------------------------------------
--------------------III. Tạo khóa ngoại cho các bảng

-- 1. Tài khoản
alter table TaiKhoan add constraint fk_Quyen_TaiKhoan foreign key (MaQuyen) references Quyen(MaQuyen)
go
alter table TaiKhoan add constraint fk_MaNhanVien_TaiKhoan foreign key (MaNhanVien) references NhanVien(MaNhanVien) on update cascade on delete cascade
go

-- 2. Hồ sơ kỷ luật
alter table HoSoKyLuat add constraint fk_MaNhanVien_HoSoKyLuat foreign key (MaNhanVien) references NhanVien(MaNhanVien) on update cascade on delete cascade
go

-- 3. Khen thưởng
alter table KhenThuong add constraint fk_MaNhanVien_KhenThuong foreign key (MaNhanVien) references NhanVien(MaNhanVien)

-- 4. Phòng ban
alter table PhongBan add constraint fk_TruongPhong_PhongBan foreign key (TruongPhong) references NhanVien(MaNhanVien)
go

-- 5. Chức vụ
alter table ChucVu add constraint fk_PhongBan_ChucVu foreign key (PhongBan) references PhongBan(MaPhongBan)
go

-- 6. Dự án
alter table DuAn add constraint fk_QuanLyDuAn_DuAn foreign key (QuanLyDuAn) references NhanVien(MaNhanVien)
go
alter table DuAn add constraint fk_PhongBanPhuTrach_DuAn foreign key (PhongBanPhuTrach) references PhongBan(MaPhongBan)
go

-- 7. Quản lý nhân sự
alter table QuanLyNhanSu add constraint fk_MaQuanLyNhanSu_QuanLyNhanSu foreign key (MaQuanLyNhanSu) references NhanVien(MaNhanVien)
go

-- 8. Nhân Viên
alter table NhanVien add constraint fk_NguoiQuanLy_NhanVien foreign key (NguoiQuanLy) references QuanLyNhanSu(MaQuanLyNhanSu)
go
alter table NhanVien add constraint fk_PhongBan_NhanVien foreign key (PhongBan) references PhongBan(MaPhongBan)
go
alter table NhanVien add constraint fk_ChucVu_NhanVien foreign key (ChucVu) references ChucVu(MaChucVu)
go
alter table NhanVien add constraint fk_HoSoGioiThieu_NhanVien foreign key (HoSoGioiThieu) references HoSoTuyenDung(MaHoSoTuyenDung)
go

-- 9. Kỳ Tuyển dụng
alter table KyTuyenDung add constraint fk_MaQuanLy_KyTuyenDung foreign key (MaQuanLy) references QuanLyNhanSu(MaQuanLyNhanSu)
go

-- 10. Hồ sơ tuyển dụng
alter table HosoTuyenDung add constraint fk_KyTuyenDung_HoSoTuyenDung foreign key (KyTuyenDung) references KyTuyenDung(MaKyTuyenDung)
go

-- 11. Bảng thông báo
alter table BangThongBao add constraint fk_NguoiBanHanh_BangThongBao foreign key (NguoiBanHanh) references QuanLyNhanSu(MaQuanLyNhanSu)
go

-- 12. Bảng lương
alter table BangLuong add constraint fk_MaNhanVien_BangLuong foreign key (MaNhanVien) references NhanVien(MaNhanVien) on update cascade on delete cascade
go

-- 13. Chi tiết phúc lợi nhân viên
alter table ChiTietPhucLoiNhanVien add constraint fk_MaPhucLoi_ChiTietPhucLoiNhanVien foreign key (MaPhucLoi) references PhucLoi(MaPhucLoi) on update cascade on delete cascade
go
alter table ChiTietPhucLoiNhanVien add constraint fk_MaNhanVien_ChiTietPhucLoiNhanVien foreign key (MaNhanVien) references NhanVien(MaNhanVien) on update cascade on delete cascade
go

-- 14. Chi Tiết dự án nhân viên
alter table ChiTietDuAnNhanVien add constraint fk_MaDuAn_ChiTietDuAnNhanVien foreign key (MaDuAn) references DuAn(MaDuAn) on update cascade on delete cascade
go
alter table ChiTietDuAnNhanVien add constraint fk_MaNhanVien_ChiTietDuAnNhanVien foreign key (MaNhanVien) references NhanVien(MaNhanVien) on update cascade on delete cascade
go

-- 15. Chi Tiết nhân viên chấm công
alter table ChiTietNhanVienChamCong add constraint fk_MaBangChamCong_ChiTietNhanVienChamCong foreign key (MaBangChamCong) references BangChamCong(MaBangChamCong) on update cascade on delete cascade
go
alter table ChiTietNhanVienChamCong add constraint fk_MaQuanLyNhanSu_ChiTietNhanVienChamCong foreign key (MaQuanLyNhanSu) references QuanLyNhanSu(MaQuanLyNhanSu) on update cascade on delete cascade
go
alter table ChiTietNhanVienChamCong add constraint fk_MaNhanVien_ChiTietNhanVienChamCong foreign key (MaNhanVien) references NhanVien(MaNhanVien) on update cascade on delete cascade
go