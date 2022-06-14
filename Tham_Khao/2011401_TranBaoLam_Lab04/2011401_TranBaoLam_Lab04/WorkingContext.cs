namespace _2011401_TranBaoLam_Lab04
{
    public static class WorkingContext
    {
        // Cái này là tạo ra danh sách sinh viên dùng chung cho tất cả các form, dùng đâu cũng được
        // Không cần phải tạo ra danh sách sinh viên
        // Cái này nó tương tự như 1 components bên Vue á, gắn đâu cũng được
        // Nhưng phải truyền dữ liệu vào cho nó
        // Thay vì thêm vào list bên lớp QuanLySinhVien thì thêm thẳng vô đây luôn
        public static StudentManagerment students = new StudentManagerment();
    }
}
