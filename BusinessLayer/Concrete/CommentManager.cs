using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;


namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            this.commentDal = commentDal;
        }
        public void Tadd(Comment t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment TgetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TgetList()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
