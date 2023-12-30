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

        public void TAdd(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetList()
        {
            throw new NotImplementedException();
        }

        public Comment TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
