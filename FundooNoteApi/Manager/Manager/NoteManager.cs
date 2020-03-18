﻿//<auto-generated/>
namespace Manager.Manager
{
    using global::Manager.IManager;
    using Model.NoteModel;
    using Repository.IRepository;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public class NoteManager : INoteManager
    {
        private readonly INoteRepository repository;
        public NoteManager(INoteRepository note)
        {
            repository = note;
        }
        public NoteManager()
        {

        }
        public async Task<string> AddNotes(NoteModel note)
        {
        await this.repository.AddNotes(note);
            return "Added Successfully";
        }

        public async Task<string> DeleteNote(int id)
        {
            await this.repository.DeleteNote(id);
            return "Deleted Successfully";

        }

        public List<NoteModel> GetNote(int id)
        {
            var result = this.repository.GetNote(id);
            return result;
        }

        public List<NoteModel> GetAllNotes()
        {
            return this.repository.GetAllNotes();
        }

        public async Task<string> UpdateNote(NoteModel note)
        {
             await this.repository.UpdateNote(note);
            return "Updated Successfully";
        }
    }
}