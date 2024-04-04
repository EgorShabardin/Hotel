using System.Windows.Forms;
using Hotel.Database;
using System.Data;
using System.Linq;
using System;
using NLog;

namespace Hotel
{
    public partial class GuestCardInformationForm : Form
    {
        #region Поля
        int dailyFee = 1000;
        int guestId = -1;
        Logger logger = LogManager.GetCurrentClassLogger();
        #endregion

        #region События
        private void SaveButtonClick(object sender, EventArgs e)
        {
            using (var database = new HotelDatabaseContext())
            {
                logger.Info("Успешное обращение к базе данных при нажатии на кнопку сохранить в карточке постояльца");
                var guestInfo = database.HotelGuests.Where(guest => guest.GuestId == guestId).FirstOrDefault();

                if (guestInfo != null)
                {
                    logger.Debug($"Загружена информация о постояльце с индексом {guestId}");
                    guestInfo.GuestCheckOutDate = DateTime.Parse(guestInfo.GuestCheckInDate).AddDays((double)amountOfDaysNumericUpDown.Value)
                                                    .ToString("dd.MM.yyyy");
                    guestInfo.IsTravelingWithAnimals = Convert.ToInt32(travelingWithAnimalsCheckBox.Checked);

                    database.SaveChanges();
                    logger.Warn($"Количество дней пребывания в отеле изменено на {amountOfDaysNumericUpDown.Value}");
                    logger.Debug($"Данные постояльца с индексом {guestId} успешно сохранены");
                }
            }
        }

        private void AmountOfDaysNumericUpDownValueChanged(object sender, EventArgs e)
        {
            paymentLabel.Text = $"Оплата {dailyFee * amountOfDaysNumericUpDown.Value} рублей";
            amountOfDaysNumericUpDown.Value = amountOfDaysNumericUpDown.Value;
        }

        private void GuestCardInformationFormFormClosing(object sender, FormClosingEventArgs e)
        {
            logger.Fatal($"Форма была закрыта по причине {e.CloseReason}");
        }
        #endregion

        #region Конструкторы
        public GuestCardInformationForm(int guestId)
        {
            InitializeComponent();

            using (var database = new HotelDatabaseContext())
            {
                logger.Info("Успешное подключение к базе данных при открытии карточки постояльца");
                var guestInfo = database.HotelGuests.Where(guest => guest.GuestId == guestId).FirstOrDefault();

                if (guestInfo != null)
                {
                    logger.Debug($"Загружена информация о постояльце с идентификатором {guestInfo.GuestId}");
                    guestFullNameLabel.Text = $"{guestInfo.GuestSurname} {guestInfo.GuestName} {guestInfo.GuestPatronymic}";
                    guestBirthdayLabel.Text = guestInfo.GuestBirthday;

                    var checkInDate = DateTime.Parse(guestInfo.GuestCheckInDate);
                    var checkOutDay = DateTime.Parse(guestInfo.GuestCheckOutDate);

                    var amountOfDays = checkOutDay.Subtract(checkInDate).TotalDays;
                    paymentLabel.Text = $"Оплата {dailyFee * amountOfDays} рублей";
                    amountOfDaysNumericUpDown.Value = (decimal)amountOfDays;
                    this.guestId = guestId;

                    if (Convert.ToBoolean(guestInfo.IsTravelingWithAnimals))
                    {
                        travelingWithAnimalsCheckBox.Checked = true;
                    }

                    logger.Trace($"Информация о постояльце с индексом {guestInfo.GuestId} успешно загружена. В форму добавлен label c" +
                        $"Фио постояльца, label с датой рождения, label с количеством дней пребывания в отеле, numericUpDown для выбора количества" +
                        $"дней пребывания в отеле и checkBox для выбора возможности путешествовать с животными");
                }
                else
                {
                    logger.Error($"Постоялец с {guestId} не обнаружено");
                }
            }
        }
        #endregion

    }
}