USE [QUANLYKHO]
GO
/****** Object:  StoredProcedure [dbo].[hienthihanghoatheoma]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[hienthihanghoatheoma]
@ma nvarchar(50)
as
begin
select * from tbl_HangHoa
where MaHH = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[hienthihanghoatheoten]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[hienthihanghoatheoten]
@ma nvarchar(50)
as
begin
select * from tbl_HangHoa
where TenHH = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[hienthikhachhangtheoma]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC   [dbo].[hienthikhachhangtheoma]
@MA nvarchar(50)
AS
BEGIN
SELECT * FROM tbl_KhachHang
where MaKH = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthikhachhangtheoten]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC   [dbo].[hienthikhachhangtheoten]
@MA nvarchar(50)
AS
BEGIN
SELECT * FROM tbl_KhachHang
where TenKH = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthikhotheoma]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC   [dbo].[hienthikhotheoma]
@ma nvarchar(50)
AS
BEGIN
select * from tbl_Kho
where MaKho = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthikhotheoten]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC  [dbo].[hienthikhotheoten]
@ma nvarchar(50)
AS
BEGIN
select * from tbl_Kho
where TenKho = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthiNCCtheoma]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[hienthiNCCtheoma]
@MA nvarchar(50)
AS
BEGIN
SELECT * FROM tbl_NCC
WHERE MaNCC = @MA
END
GO
/****** Object:  StoredProcedure [dbo].[hienthiNCCtheoten]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[hienthiNCCtheoten]
@MA nvarchar(50)
AS
BEGIN
SELECT * FROM tbl_NCC
WHERE TenNCC = @MA
END
GO
/****** Object:  StoredProcedure [dbo].[hienthinhapkhotheomahanghoa]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[hienthinhapkhotheomahanghoa]
@ma nvarchar(50)
AS
BEGIN
SELECT tbl_Kho.MaKho, tbl_Kho.TenKho,tbl_HangHoa.MaHH,tbl_HangHoa.TenHH,tbl_NCC.MaNCC,tbl_NCC.TenNCC,
tbl_PhieuNhap.SoPN,tbl_ChiTietPN.SoLuong,tbl_PhieuNhap.NgayNhap,tbl_PhieuNhap.NoiDung
FROM tbl_Kho , tbl_HangHoa, tbl_NCC,tbl_ChiTietPN,tbl_PhieuNhap
WHERE tbl_Kho.MaKho = tbl_PhieuNhap.MaKho and tbl_PhieuNhap.SoPN = tbl_ChiTietPN.SoPN and tbl_PhieuNhap.MaNCC = tbl_NCC.MaNCC and tbl_HangHoa.MaHH = tbl_ChiTietPN.MaHH and tbl_HangHoa.MaHH = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthinhapkhotheomakho]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[hienthinhapkhotheomakho]
@ma nvarchar(50)
AS
BEGIN
SELECT tbl_Kho.MaKho, tbl_Kho.TenKho,tbl_HangHoa.MaHH,tbl_HangHoa.TenHH,tbl_NCC.MaNCC,tbl_NCC.TenNCC,
tbl_PhieuNhap.SoPN,tbl_ChiTietPN.SoLuong,tbl_PhieuNhap.NgayNhap,tbl_PhieuNhap.NoiDung
FROM tbl_Kho , tbl_HangHoa, tbl_NCC,tbl_ChiTietPN,tbl_PhieuNhap
WHERE tbl_Kho.MaKho = tbl_PhieuNhap.MaKho and tbl_PhieuNhap.SoPN = tbl_ChiTietPN.SoPN and tbl_PhieuNhap.MaNCC = tbl_NCC.MaNCC and tbl_HangHoa.MaHH = tbl_ChiTietPN.MaHH and tbl_PhieuNhap.MaKho = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthinhapkhotheomanguoicungcap]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[hienthinhapkhotheomanguoicungcap]
@ma nvarchar(50)
AS
BEGIN
SELECT tbl_Kho.MaKho, tbl_Kho.TenKho,tbl_HangHoa.MaHH,tbl_HangHoa.TenHH,tbl_NCC.MaNCC,tbl_NCC.TenNCC,
tbl_PhieuNhap.SoPN,tbl_ChiTietPN.SoLuong,tbl_PhieuNhap.NgayNhap,tbl_PhieuNhap.NoiDung
FROM tbl_Kho , tbl_HangHoa, tbl_NCC,tbl_ChiTietPN,tbl_PhieuNhap
WHERE tbl_Kho.MaKho = tbl_PhieuNhap.MaKho and tbl_PhieuNhap.SoPN = tbl_ChiTietPN.SoPN and tbl_PhieuNhap.MaNCC = tbl_NCC.MaNCC and tbl_HangHoa.MaHH = tbl_ChiTietPN.MaHH and tbl_NCC.MaNCC = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthinhapkhotheotenhanghoa]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[hienthinhapkhotheotenhanghoa]
@ma nvarchar(50)
AS
BEGIN
SELECT tbl_Kho.MaKho, tbl_Kho.TenKho,tbl_HangHoa.MaHH,tbl_HangHoa.TenHH,tbl_NCC.MaNCC,tbl_NCC.TenNCC,
tbl_PhieuNhap.SoPN,tbl_ChiTietPN.SoLuong,tbl_PhieuNhap.NgayNhap,tbl_PhieuNhap.NoiDung
FROM tbl_Kho , tbl_HangHoa, tbl_NCC,tbl_ChiTietPN,tbl_PhieuNhap
WHERE tbl_Kho.MaKho = tbl_PhieuNhap.MaKho and tbl_PhieuNhap.SoPN = tbl_ChiTietPN.SoPN and tbl_PhieuNhap.MaNCC = tbl_NCC.MaNCC and tbl_HangHoa.MaHH = tbl_ChiTietPN.MaHH and tbl_HangHoa.TenHH = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthinhapkhotheotenkho]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[hienthinhapkhotheotenkho]
@ma nvarchar(50)
AS
BEGIN
SELECT tbl_Kho.MaKho, tbl_Kho.TenKho,tbl_HangHoa.MaHH,tbl_HangHoa.TenHH,tbl_NCC.MaNCC,tbl_NCC.TenNCC,
tbl_PhieuNhap.SoPN,tbl_ChiTietPN.SoLuong,tbl_PhieuNhap.NgayNhap,tbl_PhieuNhap.NoiDung
FROM tbl_Kho , tbl_HangHoa, tbl_NCC,tbl_ChiTietPN,tbl_PhieuNhap
WHERE tbl_Kho.MaKho = tbl_PhieuNhap.MaKho and tbl_PhieuNhap.SoPN = tbl_ChiTietPN.SoPN and tbl_PhieuNhap.MaNCC = tbl_NCC.MaNCC and tbl_HangHoa.MaHH = tbl_ChiTietPN.MaHH and tbl_Kho.TenKho = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthinhapkhotheotennguoicungcap]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[hienthinhapkhotheotennguoicungcap]
@ma nvarchar(50)
AS
BEGIN
SELECT tbl_Kho.MaKho, tbl_Kho.TenKho,tbl_HangHoa.MaHH,tbl_HangHoa.TenHH,tbl_NCC.MaNCC,tbl_NCC.TenNCC,
tbl_PhieuNhap.SoPN,tbl_ChiTietPN.SoLuong,tbl_PhieuNhap.NgayNhap,tbl_PhieuNhap.NoiDung
FROM tbl_Kho , tbl_HangHoa, tbl_NCC,tbl_ChiTietPN,tbl_PhieuNhap
WHERE tbl_Kho.MaKho = tbl_PhieuNhap.MaKho and tbl_PhieuNhap.SoPN = tbl_ChiTietPN.SoPN and tbl_PhieuNhap.MaNCC = tbl_NCC.MaNCC and tbl_HangHoa.MaHH = tbl_ChiTietPN.MaHH and tbl_NCC.TenNCC = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthitenthanhmahangho]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[hienthitenthanhmahangho]
@ma nvarchar(50)
as
begin
select MaHH
from tbl_HangHoa
where TenHH =@ma
end
GO
/****** Object:  StoredProcedure [dbo].[hienthitenthanhmahanghoa]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[hienthitenthanhmahanghoa]
@ma nvarchar(50)
AS
BEGIN
SELECT MaHH
FROM  tbl_HangHoa
WHERE TenHH = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthitenthanhmakh]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[hienthitenthanhmakh]
@ma nvarchar(50)
as
begin
select MaKho
from tbl_Kho
where TenKho =@ma
end
GO
/****** Object:  StoredProcedure [dbo].[hienthitenthanhmakhachhang]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[hienthitenthanhmakhachhang]
@ma nvarchar(50)
as
begin
select MaKH
from tbl_KhachHang
where TenKH =@ma
end
GO
/****** Object:  StoredProcedure [dbo].[hienthitenthanhmakho]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[hienthitenthanhmakho]
@ma nvarchar(50)
AS
BEGIN
SELECT MaKho
FROM  tbl_Kho
WHERE TenKho = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthitenthanhmanhacungcap]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[hienthitenthanhmanhacungcap]
@ma nvarchar(50)
AS
BEGIN
SELECT MaNCC
FROM  tbl_NCC
WHERE TenNCC = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthixuatkhotheomahanghoa]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[hienthixuatkhotheomahanghoa]
@ma nvarchar(50)
AS
BEGIN
SELECT tbl_Kho.MaKho, tbl_Kho.TenKho,tbl_HangHoa.MaHH,tbl_HangHoa.TenHH,tbl_KhachHang.MaKH,tbl_KhachHang.TenKH,
tbl_PhieuXuat.SoPX,tbl_ChiTietPX.SoLuong,tbl_PhieuXuat.NgayXuat,tbl_PhieuXuat.NoiDung
FROM tbl_Kho , tbl_HangHoa, tbl_KhachHang,tbl_ChiTietPX,tbl_PhieuXuat
WHERE tbl_Kho.MaKho = tbl_PhieuXuat.MaKho and tbl_PhieuXuat.SoPX = tbl_ChiTietPX.SoPX and tbl_PhieuXuat.MaKH= tbl_KhachHang.MaKH and tbl_HangHoa.MaHH = tbl_ChiTietPX.MaHH and tbl_HangHoa.MaHH = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthixuatkhotheomakhachhang]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[hienthixuatkhotheomakhachhang]
@ma nvarchar(50)
AS
BEGIN
SELECT tbl_Kho.MaKho, tbl_Kho.TenKho,tbl_HangHoa.MaHH,tbl_HangHoa.TenHH,tbl_KhachHang.MaKH,tbl_KhachHang.TenKH,
tbl_PhieuXuat.SoPX,tbl_ChiTietPX.SoLuong,tbl_PhieuXuat.NgayXuat,tbl_PhieuXuat.NoiDung
FROM tbl_Kho , tbl_HangHoa, tbl_KhachHang,tbl_ChiTietPX,tbl_PhieuXuat
WHERE tbl_Kho.MaKho = tbl_PhieuXuat.MaKho and tbl_PhieuXuat.SoPX = tbl_ChiTietPX.SoPX and tbl_PhieuXuat.MaKH= tbl_KhachHang.MaKH and tbl_HangHoa.MaHH = tbl_ChiTietPX.MaHH and tbl_KhachHang.MaKH = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthixuatkhotheomakho]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[hienthixuatkhotheomakho]
@ma nvarchar(50)
AS
BEGIN
SELECT tbl_Kho.MaKho, tbl_Kho.TenKho,tbl_HangHoa.MaHH,tbl_HangHoa.TenHH,tbl_KhachHang.MaKH,tbl_KhachHang.TenKH,
tbl_PhieuXuat.SoPX,tbl_ChiTietPX.SoLuong,tbl_PhieuXuat.NgayXuat,tbl_PhieuXuat.NoiDung
FROM tbl_Kho , tbl_HangHoa, tbl_KhachHang,tbl_ChiTietPX,tbl_PhieuXuat
WHERE tbl_Kho.MaKho = tbl_PhieuXuat.MaKho and tbl_PhieuXuat.SoPX = tbl_ChiTietPX.SoPX and tbl_PhieuXuat.MaKH= tbl_KhachHang.MaKH and tbl_HangHoa.MaHH = tbl_ChiTietPX.MaHH and tbl_Kho.MaKho = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthixuatkhotheotenhanghoa]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[hienthixuatkhotheotenhanghoa]
@ma nvarchar(50)
AS
BEGIN
SELECT tbl_Kho.MaKho, tbl_Kho.TenKho,tbl_HangHoa.MaHH,tbl_HangHoa.TenHH,tbl_KhachHang.MaKH,tbl_KhachHang.TenKH,
tbl_PhieuXuat.SoPX,tbl_ChiTietPX.SoLuong,tbl_PhieuXuat.NgayXuat,tbl_PhieuXuat.NoiDung
FROM tbl_Kho , tbl_HangHoa, tbl_KhachHang,tbl_ChiTietPX,tbl_PhieuXuat
WHERE tbl_Kho.MaKho = tbl_PhieuXuat.MaKho and tbl_PhieuXuat.SoPX = tbl_ChiTietPX.SoPX and tbl_PhieuXuat.MaKH= tbl_KhachHang.MaKH and tbl_HangHoa.MaHH = tbl_ChiTietPX.MaHH and tbl_HangHoa.TenHH = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthixuatkhotheotenkhachhang]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[hienthixuatkhotheotenkhachhang]
@ma nvarchar(50)
AS
BEGIN
SELECT tbl_Kho.MaKho, tbl_Kho.TenKho,tbl_HangHoa.MaHH,tbl_HangHoa.TenHH,tbl_KhachHang.MaKH,tbl_KhachHang.TenKH,
tbl_PhieuXuat.SoPX,tbl_ChiTietPX.SoLuong,tbl_PhieuXuat.NgayXuat,tbl_PhieuXuat.NoiDung
FROM tbl_Kho , tbl_HangHoa, tbl_KhachHang,tbl_ChiTietPX,tbl_PhieuXuat
WHERE tbl_Kho.MaKho = tbl_PhieuXuat.MaKho and tbl_PhieuXuat.SoPX = tbl_ChiTietPX.SoPX and tbl_PhieuXuat.MaKH= tbl_KhachHang.MaKH and tbl_HangHoa.MaHH = tbl_ChiTietPX.MaHH and tbl_KhachHang.TenKH = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[hienthixuatkhotheotenkho]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[hienthixuatkhotheotenkho]
@ma nvarchar(50)
AS
BEGIN
SELECT tbl_Kho.MaKho, tbl_Kho.TenKho,tbl_HangHoa.MaHH,tbl_HangHoa.TenHH,tbl_KhachHang.MaKH,tbl_KhachHang.TenKH,
tbl_PhieuXuat.SoPX,tbl_ChiTietPX.SoLuong,tbl_PhieuXuat.NgayXuat,tbl_PhieuXuat.NoiDung
FROM tbl_Kho , tbl_HangHoa, tbl_KhachHang,tbl_ChiTietPX,tbl_PhieuXuat
WHERE tbl_Kho.MaKho = tbl_PhieuXuat.MaKho and tbl_PhieuXuat.SoPX = tbl_ChiTietPX.SoPX and tbl_PhieuXuat.MaKH= tbl_KhachHang.MaKH and tbl_HangHoa.MaHH = tbl_ChiTietPX.MaHH and tbl_Kho.TenKho = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[laymahanghoa]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[laymahanghoa]
as
begin
select MaHH from tbl_HangHoa
end
GO
/****** Object:  StoredProcedure [dbo].[laymakhachhang]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC   [dbo].[laymakhachhang]
AS
BEGIN
SELECT MaKH FROM tbl_KhachHang
END
GO
/****** Object:  StoredProcedure [dbo].[laymakho]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC   [dbo].[laymakho]
AS
BEGIN
select MaKho from tbl_Kho
END
GO
/****** Object:  StoredProcedure [dbo].[laymaNCC]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[laymaNCC]
AS
BEGIN
SELECT MaNCC FROM tbl_NCC
END
GO
/****** Object:  StoredProcedure [dbo].[laytenhanghoa]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[laytenhanghoa]
as
begin
select TenHH from tbl_HangHoa
end
GO
/****** Object:  StoredProcedure [dbo].[laytenkhachhang]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC   [dbo].[laytenkhachhang]
AS
BEGIN
SELECT TenKH FROM tbl_KhachHang
END
GO
/****** Object:  StoredProcedure [dbo].[laytenkho]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC   [dbo].[laytenkho]
AS
BEGIN
select TenKho from tbl_Kho
END
GO
/****** Object:  StoredProcedure [dbo].[laytenNCC]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[laytenNCC]
AS
BEGIN
SELECT TenNCC FROM tbl_NCC
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHIDANGNHAP_ALL]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROC   [dbo].[PR_HIENTHIDANGNHAP_ALL]
AS
BEGIN
SELECT * FROM tbl_DangNhap
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHIHH_ALL]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PR_HIENTHIHH_ALL]
as
begin
select * from tbl_HangHoa
end
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHIKHACHHANG_ALL]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC   [dbo].[PR_HIENTHIKHACHHANG_ALL]
AS
BEGIN
SELECT * FROM tbl_KhachHang
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHIKHO_ALL]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC   [dbo].[PR_HIENTHIKHO_ALL]
AS
BEGIN
select * from tbl_Kho
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHINCC_ALL]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_HIENTHINCC_ALL]
AS
BEGIN
SELECT * FROM tbl_NCC
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHINHAPKHO_ALL]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[PR_HIENTHINHAPKHO_ALL]
AS
BEGIN
SELECT tbl_Kho.MaKho, tbl_Kho.TenKho,tbl_HangHoa.MaHH,tbl_HangHoa.TenHH,tbl_NCC.MaNCC,tbl_NCC.TenNCC,
tbl_PhieuNhap.SoPN,tbl_ChiTietPN.SoLuong,tbl_PhieuNhap.NgayNhap,tbl_PhieuNhap.NoiDung
FROM tbl_Kho , tbl_HangHoa, tbl_NCC,tbl_ChiTietPN,tbl_PhieuNhap
WHERE tbl_Kho.MaKho = tbl_PhieuNhap.MaKho and tbl_PhieuNhap.SoPN = tbl_ChiTietPN.SoPN and tbl_PhieuNhap.MaNCC = tbl_NCC.MaNCC and tbl_HangHoa.MaHH = tbl_ChiTietPN.MaHH
END
GO
/****** Object:  StoredProcedure [dbo].[PR_HIENTHIXUATKHO_ALL]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[PR_HIENTHIXUATKHO_ALL]
AS
BEGIN
SELECT tbl_Kho.MaKho, tbl_Kho.TenKho,tbl_HangHoa.MaHH,tbl_HangHoa.TenHH,tbl_KhachHang.MaKH,tbl_KhachHang.TenKH,
tbl_PhieuXuat.SoPX,tbl_ChiTietPX.SoLuong,tbl_PhieuXuat.NgayXuat,tbl_PhieuXuat.NoiDung
FROM tbl_Kho , tbl_HangHoa, tbl_KhachHang,tbl_ChiTietPX,tbl_PhieuXuat
WHERE tbl_Kho.MaKho = tbl_PhieuXuat.MaKho and tbl_PhieuXuat.SoPX = tbl_ChiTietPX.SoPX and tbl_PhieuXuat.MaKH= tbl_KhachHang.MaKH and tbl_HangHoa.MaHH = tbl_ChiTietPX.MaHH
END
GO
/****** Object:  StoredProcedure [dbo].[PR_SUA_DANGNHAP]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_SUA_DANGNHAP]
@manv nvarchar(50),
@tennv nvarchar(50), 
@matp nvarchar(50)

AS
BEGIN
UPDATE tbl_DangNhap
SET 
PassWord = @tennv,
Quyen = @matp

WHERE UserName = @manv
END
GO
/****** Object:  StoredProcedure [dbo].[PR_SUA_HH]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PR_SUA_HH]
@ma nvarchar(50),
@ten nvarchar(50),
@dv nvarchar(50)
as
begin
update tbl_HangHoa
set TenHH = @ten,
DVT = @dv
where MaHH = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[PR_SUA_KHACHHANG]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC   [dbo].[PR_SUA_KHACHHANG]
@makh nvarchar(50),
@tenkh nvarchar(50), 
@diachi nvarchar(50), 
@dienthoai nvarchar(50), 
@email nvarchar(50), 
@ghichu nvarchar(50)
AS
BEGIN
UPDATE tbl_KhachHang
SET 
TenKH = @tenkh,
DiaChi = @diachi,
DienThoai = @dienthoai,
Email = @email,
GhiChu = @ghichu
WHERE MaKH = @makh
END
GO
/****** Object:  StoredProcedure [dbo].[PR_SUA_KHO]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC  [dbo].[PR_SUA_KHO]
@ma nvarchar(50),
@ten nvarchar(50)
AS
BEGIN
update tbl_Kho
set 
TenKho = @ten
where MaKho = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[PR_SUA_NCC]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_SUA_NCC]
@MA nvarchar(50),
@ten nvarchar(50),
@dc nvarchar(50),
@dt nvarchar(50),
@mail nvarchar(50),
@ghi nvarchar(50)
AS
BEGIN
UPDATE tbl_NCC
SET
TenNCC = @ten,
DiaChi = @dc,
DienThoai = @dt,
Email = @mail,
GhiChu = @ghi
WHERE MaNCC = @MA
END
GO
/****** Object:  StoredProcedure [dbo].[PR_SUA_NHAPKHO]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PR_SUA_NHAPKHO]
@sopn nvarchar(50),
@makho nvarchar(50),
@ngaynhap nvarchar(50),
@mancc nvarchar(50),
@noidung nvarchar(50),
@mahh nvarchar(50),
@soluong nvarchar(50)
as
begin
update tbl_ChiTietPN
set SoPN = @sopn,MaKho = @makho,MaHH = @mahh, SoLuong = @soluong
update tbl_PhieuNhap
set SoPN = @sopn , MaKho = @makho,NgayNhap=@ngaynhap,MaNCC = @mancc,NoiDung = @noidung
end
GO
/****** Object:  StoredProcedure [dbo].[PR_SUA_XUATKHO]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PR_SUA_XUATKHO]
@sopn nvarchar(50),
@makho nvarchar(50),
@ngaynhap nvarchar(50),
@mancc nvarchar(50),
@noidung nvarchar(50),
@mahh nvarchar(50),
@soluong nvarchar(50)
as
begin
update tbl_ChiTietPX
set SoPX = @sopn,MaKho = @makho,MaHH = @mahh, SoLuong = @soluong
update tbl_PhieuXuat
set SoPX = @sopn , MaKho = @makho,NgayXuat=@ngaynhap,MaKH = @mancc,NoiDung = @noidung
end
GO
/****** Object:  StoredProcedure [dbo].[PR_THEM_DANGNHAP]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC   [dbo].[PR_THEM_DANGNHAP]
@manv nvarchar(50),
@tennv nvarchar(50), 
@matp nvarchar(50)
AS
BEGIN
INSERT INTO tbl_DangNhap(UserName,PassWord,Quyen)
VALUES (@manv ,
@tennv , 
@matp )
END
GO
/****** Object:  StoredProcedure [dbo].[PR_THEM_HH]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PR_THEM_HH]
@ma nvarchar(50),
@ten nvarchar(50),
@dv nvarchar(50)
as
begin
insert into tbl_HangHoa (MaHH,TenHH,DVT)
values (@ma,@ten,@dv)
end
GO
/****** Object:  StoredProcedure [dbo].[PR_THEM_KHACHHANG]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC   [dbo].[PR_THEM_KHACHHANG]
@makh nvarchar(50),
@tenkh nvarchar(50), 
@diachi nvarchar(50), 
@dienthoai nvarchar(50), 
@email nvarchar(50), 
@ghichu nvarchar(50)
AS
BEGIN
INSERT INTO tbl_KhachHang(MaKH,TenKH,DiaChi,DienThoai,Email,GhiChu)
VALUES (@makh,@tenkh,@diachi,@dienthoai,@email,@ghichu)
END
GO
/****** Object:  StoredProcedure [dbo].[PR_THEM_KHO]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC  [dbo].[PR_THEM_KHO]
@ma nvarchar(50),
@ten nvarchar(50)
AS
BEGIN
insert into tbl_Kho(MaKho,TenKho)
values (@ma,@ten)
END
GO
/****** Object:  StoredProcedure [dbo].[PR_THEM_NCC]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_THEM_NCC]
@MA nvarchar(50),
@ten nvarchar(50),
@dc nvarchar(50),
@dt nvarchar(50),
@mail nvarchar(50),
@ghi nvarchar(50)
AS
BEGIN
INSERT INTO tbl_NCC(MaNCC,TenNCC,DiaChi,DienThoai,Email,GhiChu)
values (@MA,@ten,@dc,@dt,@mail,@ghi)
END
GO
/****** Object:  StoredProcedure [dbo].[PR_THEM_NHAPKHO]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PR_THEM_NHAPKHO]
@sopn nvarchar(50),
@makho nvarchar(50),
@ngaynhap nvarchar(50),
@mancc nvarchar(50),
@noidung nvarchar(50),
@mahh nvarchar(50),
@soluong nvarchar(50)
as
begin
insert into tbl_PhieuNhap(SoPN,MaKho,NgayNhap,MaNCC,NoiDung)
values (@sopn,@makho,@ngaynhap,@mancc,@noidung)
insert into tbl_ChiTietPN(SoPN,MaKho,MaHH,SoLuong)
values (@sopn,@makho,@mahh,@soluong)
end
GO
/****** Object:  StoredProcedure [dbo].[PR_THEM_XUATKHO]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PR_THEM_XUATKHO]
@sopn nvarchar(50),
@makho nvarchar(50),
@ngaynhap nvarchar(50),
@mancc nvarchar(50),
@noidung nvarchar(50),
@mahh nvarchar(50),
@soluong nvarchar(50)
as
begin
insert into tbl_PhieuXuat(SoPX,MaKho,NgayXuat,MaKH,NoiDung)
values (@sopn,@makho,@ngaynhap,@mancc,@noidung)
insert into tbl_ChiTietPX(SoPX,MaKho,MaHH,SoLuong)
values (@sopn,@makho,@mahh,@soluong)
end
GO
/****** Object:  StoredProcedure [dbo].[PR_XACTHUC]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PR_XACTHUC]
	@username nvarchar(50),
	@password nvarchar(50)
AS
BEGIN
	select quyen from tbl_DangNhap where UserName =@username and PassWord = @password
END

GO
/****** Object:  StoredProcedure [dbo].[PR_XOA_DANGNHAP]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_XOA_DANGNHAP]
	@MASV	NVARCHAR(10)	
AS
BEGIN
DELETE tbl_DangNhap
WHERE UserName = @MASV

END
GO
/****** Object:  StoredProcedure [dbo].[PR_XOA_HH]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PR_XOA_HH]
@ma nvarchar(50)
as
begin
delete tbl_HangHoa
where MaHH = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[PR_XOA_KHACHHANG]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC   [dbo].[PR_XOA_KHACHHANG]
@makh nvarchar(50)
AS
BEGIN
DELETE tbl_KhachHang
WHERE MaKH = @makh
END
GO
/****** Object:  StoredProcedure [dbo].[PR_XOA_KHO]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC  [dbo].[PR_XOA_KHO]
@ma nvarchar(50)
AS
BEGIN
delete tbl_Kho
where MaKho=@ma
END
GO
/****** Object:  StoredProcedure [dbo].[PR_XOA_NCC]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PR_XOA_NCC]
@MA nvarchar(50)
AS
BEGIN
DELETE tbl_NCC
WHERE MaNCC = @MA
END
GO
/****** Object:  StoredProcedure [dbo].[PR_XOA_NHAPKHO]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PR_XOA_NHAPKHO]
@sopn nvarchar(50)

as
begin
delete tbl_ChiTietPN
where SoPN = @sopn
delete tbl_PhieuNhap
where SoPN = @sopn
end
GO
/****** Object:  StoredProcedure [dbo].[PR_XOA_XUATKHO]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[PR_XOA_XUATKHO]
@sopn nvarchar(50)

as
begin
delete tbl_ChiTietPX
where SoPX = @sopn
delete tbl_PhieuXuat
where SoPX = @sopn
end
GO
/****** Object:  Table [dbo].[tbl_ChiTietPN]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChiTietPN](
	[SoPN] [nvarchar](50) NOT NULL,
	[MaKho] [nvarchar](50) NOT NULL,
	[MaHH] [nvarchar](50) NOT NULL,
	[SoLuong] [nvarchar](50) NULL,
	[Gia] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_ChiTietPN_1] PRIMARY KEY CLUSTERED 
(
	[SoPN] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_ChiTietPX]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChiTietPX](
	[SoPX] [nvarchar](50) NOT NULL,
	[MaHH] [nvarchar](50) NOT NULL,
	[MaKho] [nvarchar](50) NOT NULL,
	[SoLuong] [nvarchar](50) NULL,
	[Gia] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_ChiTietPX] PRIMARY KEY CLUSTERED 
(
	[SoPX] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_DangNhap]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_DangNhap](
	[UserName] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](50) NULL,
	[Quyen] [int] NULL,
 CONSTRAINT [PK_tbl_DangNhap] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_HangHoa]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HangHoa](
	[MaHH] [nvarchar](50) NOT NULL,
	[TenHH] [nvarchar](50) NOT NULL,
	[DVT] [nvarchar](50) NULL,
	[SL] [int] NULL,
 CONSTRAINT [PK_tbl_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_KhachHang]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_KhachHang](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](500) NULL,
 CONSTRAINT [PK_tbl_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Kho]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Kho](
	[MaKho] [nvarchar](50) NOT NULL,
	[TenKho] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_KHO] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_NCC]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_NCC](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](500) NULL,
 CONSTRAINT [PK_tbl_NCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_PhieuNhap]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuNhap](
	[SoPN] [nvarchar](50) NOT NULL,
	[MaKho] [nvarchar](50) NOT NULL,
	[NgayNhap] [nvarchar](50) NULL,
	[MaNCC] [nvarchar](50) NOT NULL,
	[NoiDung] [nvarchar](500) NULL,
 CONSTRAINT [PK_tbl_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[SoPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_PhieuXuat]    Script Date: 11/21/2016 2:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuXuat](
	[SoPX] [nvarchar](50) NOT NULL,
	[MaKho] [nvarchar](50) NOT NULL,
	[NgayXuat] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
	[NoiDung] [nvarchar](500) NULL,
 CONSTRAINT [PK_tbl_PhieuXuat] PRIMARY KEY CLUSTERED 
(
	[SoPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tbl_ChiTietPN]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ChiTietPN_tbl_HangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[tbl_HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[tbl_ChiTietPN] CHECK CONSTRAINT [FK_tbl_ChiTietPN_tbl_HangHoa]
GO
ALTER TABLE [dbo].[tbl_ChiTietPN]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ChiTietPN_tbl_PhieuNhap] FOREIGN KEY([SoPN])
REFERENCES [dbo].[tbl_PhieuNhap] ([SoPN])
GO
ALTER TABLE [dbo].[tbl_ChiTietPN] CHECK CONSTRAINT [FK_tbl_ChiTietPN_tbl_PhieuNhap]
GO
ALTER TABLE [dbo].[tbl_ChiTietPX]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ChiTietPX_tbl_HangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[tbl_HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[tbl_ChiTietPX] CHECK CONSTRAINT [FK_tbl_ChiTietPX_tbl_HangHoa]
GO
ALTER TABLE [dbo].[tbl_ChiTietPX]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ChiTietPX_tbl_PhieuXuat] FOREIGN KEY([SoPX])
REFERENCES [dbo].[tbl_PhieuXuat] ([SoPX])
GO
ALTER TABLE [dbo].[tbl_ChiTietPX] CHECK CONSTRAINT [FK_tbl_ChiTietPX_tbl_PhieuXuat]
GO
ALTER TABLE [dbo].[tbl_PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PhieuNhap_tbl_Kho] FOREIGN KEY([MaKho])
REFERENCES [dbo].[tbl_Kho] ([MaKho])
GO
ALTER TABLE [dbo].[tbl_PhieuNhap] CHECK CONSTRAINT [FK_tbl_PhieuNhap_tbl_Kho]
GO
ALTER TABLE [dbo].[tbl_PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PhieuNhap_tbl_NCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tbl_NCC] ([MaNCC])
GO
ALTER TABLE [dbo].[tbl_PhieuNhap] CHECK CONSTRAINT [FK_tbl_PhieuNhap_tbl_NCC]
GO
ALTER TABLE [dbo].[tbl_PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PhieuXuat_tbl_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tbl_KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tbl_PhieuXuat] CHECK CONSTRAINT [FK_tbl_PhieuXuat_tbl_KhachHang]
GO
ALTER TABLE [dbo].[tbl_PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PhieuXuat_tbl_Kho] FOREIGN KEY([MaKho])
REFERENCES [dbo].[tbl_Kho] ([MaKho])
GO
ALTER TABLE [dbo].[tbl_PhieuXuat] CHECK CONSTRAINT [FK_tbl_PhieuXuat_tbl_Kho]
GO
