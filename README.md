# ShoeShop
- cài đặt visual studio , Xampp, MySQL
- mở visual studio-> new project paste link git repo vào và clone 
- mở Xampp, start Apache và MySQL
- mở MySQL chạy câu lệnh sql "CREATE database `shoe_shop`;" để tạo database
- trở lại visual studio, tại mục Package Manager Console chạy các câu lệnh:
  + Add-Migration InitialCreate
  + Update-Database
  + dotnet run seed
- tại visual studio ctrl + f5 để chạy chế độ không debug
- đăng ký tài khoản khách hàng, tài khoản admin tk: nqha20902@gmail.com ; mk: Coding@1234?
