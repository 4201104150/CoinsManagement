# CoinsManagement
cập nhật chức năng thêm,xóa,sửa Nhân viên,
cập nhật data thông qua api
cập nhật các chức năng form1
chưa cập nhật chức năng login


bảng nhân viên,


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

table coin


create table CoinUSD
(
  IDD number primary key,
  Names varchar2(100),
  Symbol varchar2(100),
  Slug varchar2(100),
  ranks varchar2(100),
  price varchar2(100),
  Change1h varchar2(100),
  Change24h varchar2(100),
  Change1d varchar2(100),
  Updates varchar2(100)
);
create table CoinEUR
(
  IDD number primary key,
  Names varchar2(100),
  Symbol varchar2(100),
  Slug varchar2(100),
  ranks varchar2(100),
  price varchar2(100),
  Change1h varchar2(100),
  Change24h varchar2(100),
  Change1d varchar2(100),
  Updates varchar2(100)
);
create table CoinJPY
(
  IDD number primary key,
  Names varchar2(100),
  Symbol varchar2(100),
  Slug varchar2(100),
  ranks varchar2(100),
  price varchar2(100),
  Change1h varchar2(100),
  Change24h varchar2(100),
  Change1d varchar2(100),
  Updates varchar2(100)
);
create table CoinVND
(
  IDD number primary key,
  Names varchar2(100),
  Symbol varchar2(100),
  Slug varchar2(100),
  ranks varchar2(100),
  price varchar2(100),
  Change1h varchar2(100),
  Change24h varchar2(100),
  Change1d varchar2(100),
  Updates varchar2(100)
);
