using System;
using System.Linq;
using System.Windows.Forms;
using EfFormAppProject.Data;
using EfFormAppProject.Models;

namespace EfFormAppProject
{
    public partial class DersSecimi : Form
    {
        private readonly Student _student;

        public DersSecimi(Student student)
        {
            InitializeComponent();
            _student = student;
            lblOgrenciBilgi.Text = $"Seçilen Öğrenci: {_student.StudentName} {_student.StudentSurname}";
        }

        private void DersSecimi_Load(object sender, EventArgs e)
        {
            DersleriYukle();
        }

        private void DersleriYukle()
        {
            using (var context = new ObsDbContext())
            {
                // Öğrencinin daha önce seçtiği dersleri al
                var selectedLessonIds = context.StudentLessons
                    .Where(sl => sl.StudentId == _student.StudentId)
                    .Select(sl => sl.LessonId)
                    .ToList();

                // Tüm dersleri al ve daha önce seçilenleri işaretle
                var dersler = context.Lessons.Select(d => new
                {
                    d.LessonId,
                    d.LessonName,
                    IsSelected = selectedLessonIds.Contains(d.LessonId)
                }).ToList();

                // DataGridView'e ata
                dataGridViewDersler.DataSource = dersler;

                // Kolon düzenlemeleri
                dataGridViewDersler.Columns["LessonId"].Visible = false;
                dataGridViewDersler.Columns["LessonName"].HeaderText = "Ders Adı";
                dataGridViewDersler.Columns["IsSelected"].Visible = false; // Gizle, sadece kontrol için var
                dataGridViewDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // CheckBox sütununu ekle
                var checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    HeaderText = "Seç",
                    Name = "CheckColumn"
                };
                dataGridViewDersler.Columns.Insert(0, checkBoxColumn);

                // Daha önce seçilen dersleri işaretle ve düzenlemeyi engelle
                foreach (DataGridViewRow row in dataGridViewDersler.Rows)
                {
                    var isSelected = (bool)row.Cells["IsSelected"].Value;
                    if (isSelected)
                    {
                        row.Cells["CheckColumn"].Value = true;
                        row.Cells["CheckColumn"].ReadOnly = true; // Düzenlemeyi engelle
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray; // Renk değiştir
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (var context = new ObsDbContext())
            {
                var selectedLessons = dataGridViewDersler.Rows.Cast<DataGridViewRow>()
                    .Where(row => Convert.ToBoolean(row.Cells["CheckColumn"].Value) == true &&
                                  !Convert.ToBoolean(row.Cells["IsSelected"].Value)) // Daha önce seçilmiş dersleri hariç tut
                    .Select(row => new
                    {
                        LessonId = (int)row.Cells["LessonId"].Value,
                        LessonName = (string)row.Cells["LessonName"].Value
                    }).ToList();

                if (!selectedLessons.Any())
                {
                    MessageBox.Show("Lütfen yeni dersler seçiniz!");
                    return;
                }

                foreach (var ders in selectedLessons)
                {
                    var studentLesson = new StudentLesson
                    {
                        StudentId = _student.StudentId,
                        LessonId = ders.LessonId
                    };

                    context.StudentLessons.Add(studentLesson);
                }

                context.SaveChanges();

                MessageBox.Show("Seçilen dersler başarıyla kaydedildi!");
                Close();
            }
        }
    }
}