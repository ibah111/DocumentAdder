using System.Collections.Generic;

namespace DocumentAdder.Models
{
    public class SettingsModel
    {
        public string тип_документа;
        public int цвет_карточки;
        public bool номер_кд;
        public bool номер_дела;
        public bool номер_ип;
        public bool номер_испол;
        public bool дата_вынесения_решения;
        public bool дата_вступления_в_силу;
        public bool дата_возбуждения;
        public bool дата_пост_об_окончании_ип;
        public bool дата_получения_агентством;
        public bool дата_возврата;
        public bool дата_ограничения_выезда;
        public bool дата_отказа_в_возбуждении;
        public bool дата_отмены_сп;
        public bool дата_исполнения_недостатков;
        public bool дата_и_время_сз;
        public Dictionary<int, int> судебн_статус = new();
        public int? испол_статус;
        public Dictionary<int, List<int>> без_смены_суд = new();
        public List<int> без_смены_ид = new();
        public bool штрих_код;
        public int? исполнитель;
        public string название_документа = null;
        public bool связь_суда = false;
    }
}