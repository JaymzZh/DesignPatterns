namespace Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonManager jinli = new CommonManager("金立");
            Majordomo zongjian = new Majordomo("中坚");
            GeneralManager zhongjingli = new GeneralManager("仲景离");
            jinli.SetSuperior(zongjian);
            zongjian.SetSuperior(zhongjingli);

            Request request1 = new Request
            {
                RequestType = "请假",
                RequestContent = "小菜请假",
                Number = 1
            };
            jinli.RequestApplications(request1);

            Request request2 = new Request
            {
                RequestType = "请假",
                RequestContent = "小菜请假",
                Number = 4
            };
            jinli.RequestApplications(request2);

            Request request3 = new Request
            {
                RequestType = "加薪",
                RequestContent = "小菜请求加薪",
                Number = 500
            };
            jinli.RequestApplications(request3);

            Request request4 = new Request
            {
                RequestType = "加薪",
                RequestContent = "小菜请求加薪",
                Number = 1000
            };
            jinli.RequestApplications(request4);
        }
    }
}
