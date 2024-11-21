use QuanLyNhanSuCSharp
go

-- Thêm 1 phòng ban nhân sự
INSERT INTO PhongBan (MaPhongBan, TenPhongBan, MoTa, TruongPhong, TrangThai) VALUES ('PB001', N'Phòng HR', N'Phòng nhân sự', NULL, 1);
go
-- Thêm 1 phòng ban kế toán
INSERT INTO PhongBan (MaPhongBan, TenPhongBan, MoTa, TruongPhong, TrangThai) VALUES ('PB002', N'Phòng kế toán', N'Phòng kế toán', NULL, 1);
go

-- Thêm 1 chức vụ trong phòng ban nhân sự
INSERT INTO ChucVu (MaChucVu, TenChucVu, MoTa, LuongCoBan, PhongBan, TrangThai) VALUES ('CV001', N'Nhân viên nhân sự tổng hợp', N'Tuyển dụng, Đào tạo', '6000000', 'PB001', 1);
go
-- Thêm 2 chức vụ trong phòng kế toán
INSERT INTO ChucVu (MaChucVu, TenChucVu, MoTa, LuongCoBan, PhongBan, TrangThai) VALUES ('CV002', N'Kế toán tổng hợp', N'Tuyển dụng, Đào tạo', '6000000', 'PB001', 1);
go
INSERT INTO ChucVu (MaChucVu, TenChucVu, MoTa, LuongCoBan, PhongBan, TrangThai) VALUES ('CV003', N'Kế toán công nợ', N'Tuyển dụng, Đào tạo', '6000000', 'PB001', 1);
go

-- Thêm 1 nhân viên phòng nhân sự
INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, GioiTinh, DiaChi, Email, SDT, NguoiQuanLy, PhongBan, ChucVu, HoSoGioiThieu, TrangThai)
VALUES ('NV00001', N'Lê Minh Nguyệt', '2002-02-02', N'Nữ', N'TP.HCM', 'minhnguyetmongmoJ97@gmail.com', '0912345678', NULL, 'PB001', 'CV001', NULL, 1);
go

-- Thêm tài khoản cho chị Nguyệt
INSERT INTO TaiKhoan (MaTaiKhoan, TenTaiKhoan, MatKhau, MaNhanVien, MaQuyen, TrangThai) VALUES ('TK00001', 'chiNguyetxinhgai', 'modomdomJ97', 'NV00001', 'Q003', 1);
go

-- Thêm chị quản lý Lê Minh Nguyệt
INSERT INTO QuanLyNhanSu(MaQuanLyNhanSu, TrangThai)
VALUES ('NV00001', 1);
go

-- Thêm 1 kỳ tuyển dụng
INSERT INTO KyTuyenDung (MaKyTuyenDung, NoiDung, NgayBatDau, NgayKetThuc, MaQuanLy, TrangThai) VALUES ('TD001', N'Tuyển kế toán', '2024-12-12', '2025-11-11', 'NV00001', 1);
go

-- Thêm 3 hồ sơ tuyển dụng
INSERT INTO HoSoTuyenDung (MaHoSoTuyenDung, HoTen, NgaySinh, GioiTinh, DiaChi, Email, SDT, TrinhDo, MoTaBangCap, KyTuyenDung, TrangThai)
VALUES
('HS00001', N'Nguyễn Văn Lê', '1999-01-01', N'Nam', N'TP.HCM', 'avannguyen@gmail.com', '0931245678', N'Đại học', NULL, 'TD001', 0),
('HS00002', N'Nguyễn Văn Minh', '1998-01-01', N'Nam', N'TP.HCM', 'nguyetthuc@gmail.com', '0987654321', N'Đại học', NULL, 'TD001', 0),
('HS00003', N'Nguyễn Văn Nguyệt', '1997-01-01', N'Nam', N'TP.HCM', 'minhminh@gmail.com', '0931245687', N'Đại học', NULL, 'TD001', 0);
go

-- Thêm 3 nhân viên
INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, GioiTinh, DiaChi, Email, SDT, NguoiQuanLy, PhongBan, ChucVu, HoSoGioiThieu, TrangThai)
VALUES
('NV00002', N'Nguyễn Văn Lê', '1999-01-01', N'Nam', N'TP.HCM', 'avannguyen@gmail.com', '0931245678', 'NV00001', 'PB002', 'CV002', 'HS00001', 1),
('NV00003', N'Nguyễn Văn Minh', '1998-01-01', N'Nam', N'TP.HCM', 'nguyetthuc@gmail.com', '0987654321', 'NV00001', 'PB002', 'CV002', 'HS00002', 1),
('NV00004', N'Nguyễn Văn Nguyệt', '1997-01-01', N'Nam', N'TP.HCM', 'minhminh@gmail.com', '0931245687', 'NV00001', 'PB002', 'CV003', 'HS00003', 1);
go

-- Thêm dữ liệu cho bảng tài khoản
INSERT INTO TaiKhoan (MaTaiKhoan, TenTaiKhoan, MatKhau, MaNhanVien, MaQuyen, TrangThai)
VALUES 
('TK00002', 'vanle', '123456', 'NV00002', 'Q001', 1),
('TK00003', 'minhnguyenvan', 'abcdef', 'NV00003', 'Q001', 1),
('TK00004', 'nguyetnguyen', 'password', 'NV00004', 'Q001', 1)
;
go

