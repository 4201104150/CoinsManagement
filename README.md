# CoinsManagement
cập nhật chức năng thêm,xóa,sửa Nhân viên,
cập nhật data thông qua api
cập nhật các chức năng form1
chưa cập nhật chức năng login


bảng nhân viên, chưa cập nhật table các loại coin
create table nhanvien
(
  idd int primary key,
  Username varchar2(100) unique not null,
  Passwords varchar2(100) not null,
  Hoten varchar2(100) not null,
  Diachi varchar2(100),
  CMND varchar2(100) not null
);

create table phongban
(
  maphg varchar2(10) primary key,
  Tenphg varchar2(100),
  Username varchar2(100)not null,
  foreign key (Username) references nhanvien(Username)
);

create procedure insNhanVien
as
begin
    insert into NHANVIEN values('1','nv1','12345','Nguyen Van A','126 Dong Den','23114355');
end;

exec insNhanVien;
