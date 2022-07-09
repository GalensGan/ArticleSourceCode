using Bentley.DgnPlatformNET.Elements;
using Bentley.GeometryNET;
using Bentley.MstnPlatformNET;
using MSAddinTest.MSTestInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleSourceCode.Bspline
{
    public class TestBspline : IMSTest_StaticMethod
    {
        [MSTest("openCurve")]
        public static void TestOpenCurve(string unparsed)
        {
            var dgnModel = Session.Instance.GetActiveDgnModel();
            var uor = dgnModel.GetModelInfo().UorPerMeter;

            List<DPoint3d> pnts = new List<DPoint3d>();
            List<double> degrees = new List<double>()
            {
                0,45,90,135,180,225,270
            };
            foreach (var degree in degrees)
            {
                pnts.Add(new DPoint3d()
                {
                    X = Angle.FromDegrees(degree).Cos * uor,
                    Y = Angle.FromDegrees(degree).Sin * uor,
                    Z = 0,
                });
            }

            // 节点 = 控制点+阶数
            List<double> knots = new List<double>()
            {
                1,1,1,1,1,1,1,1,1,1
            };

            var bspline = BsplineCurve.CreateFromPoles(pnts, knots, 3, false);
            DraftingElementSchema.ToElement(dgnModel, bspline, null)?.AddToModel();
        }

        [MSTest("bContainsLine")]
        public static void TestBsplineContainsLine(string unparsed)
        {
            var dgnModel = Session.Instance.GetActiveDgnModel();
            var uor = dgnModel.GetModelInfo().UorPerMeter;

            List<DPoint3d> pnts = new List<DPoint3d>();
            List<double> degrees = new List<double>()
            {
                0,45,90,135,180,225,270 // 7 个点
            };
            foreach (var degree in degrees)
            {
                pnts.Add(new DPoint3d()
                {
                    X = Angle.FromDegrees(degree).Cos * uor,
                    Y = Angle.FromDegrees(degree).Sin * uor,
                    Z = 0,
                });
            }

            // 3 阶，则要求有 3 个点共线
            var startPnt = pnts[2];
            var linePnt2 = startPnt - DVector3d.UnitX * uor;
            var linePnt3 = linePnt2 - DVector3d.UnitX * uor;

            // 仅三点共线
            List<DPoint3d> pntsTemp1 = new List<DPoint3d>()
            {
               pnts[0],pnts[1],startPnt,linePnt2,linePnt3
            };

            List<DPoint3d> pntsTemp2 = new List<DPoint3d>()
            {
               pnts[0],pnts[1],startPnt,startPnt,linePnt2,linePnt3,linePnt3
            };

            // 将其它点平移
            for (int i = 3; i < pnts.Count; i++)
            {
                pntsTemp1.Add(pnts[i] - DPoint3d.UnitX * 2 * uor);
                pntsTemp2.Add(pnts[i] - DPoint3d.UnitX * 2 * uor);
            }

            // 节点 = 控制点+阶数
            List<double> knots1 = new List<double>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12
            };

            List<double> knots2 = new List<double>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14
            };

            var bspline1 = BsplineCurve.CreateFromPoles(pntsTemp1, knots1, 3, false);
            DraftingElementSchema.ToElement(dgnModel, bspline1, null)?.AddToModel();

            // 对第二条曲线平移下
            var bspline2 = BsplineCurve.CreateFromPoles(pntsTemp2, knots2, 3, false);
            DTransform3d trans = DTransform3d.FromTranslation(DVector3d.UnitX * 5 * uor);
            bspline2.Transform(trans);
            DraftingElementSchema.ToElement(dgnModel, bspline2, null)?.AddToModel();
        }

        [MSTest("bThroughPnt")]
        public static void TestBspineThroughPnts(string unparsed)
        {
            var dgnModel = Session.Instance.GetActiveDgnModel();
            var uor = dgnModel.GetModelInfo().UorPerMeter;

            List<DPoint3d> pnts = new List<DPoint3d>();
            List<double> degrees = new List<double>()
            {
                0,45,90,135,180,225,270 // 7 个
            };

            foreach (var degree in degrees)
            {
                DPoint3d pnt = new DPoint3d()
                {
                    X = Angle.FromDegrees(degree).Cos * uor,
                    Y = Angle.FromDegrees(degree).Sin * uor,
                    Z = 0,
                };

                // 重复 k 次
                pnts.Add(pnt);
                pnts.Add(pnt);
                pnts.Add(pnt);
            }

            // 节点 = 控制点+阶数
            List<double> knots = new List<double>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24
            };

            var bspline = BsplineCurve.CreateFromPoles(pnts, knots, 3, false);
            DraftingElementSchema.ToElement(dgnModel, bspline, null)?.AddToModel();
        }

        [MSTest("bDoubleKnots")]
        public static void TestBspineDoubleKnots(string unparsed)
        {
            var dgnModel = Session.Instance.GetActiveDgnModel();
            var uor = dgnModel.GetModelInfo().UorPerMeter;

            List<DPoint3d> pnts = new List<DPoint3d>();
            List<double> degrees = new List<double>()
            {
                0,45,90,135,180,225,270 // 7 个
            };

            foreach (var degree in degrees)
            {
                DPoint3d pnt = new DPoint3d()
                {
                    X = Angle.FromDegrees(degree).Cos * uor,
                    Y = Angle.FromDegrees(degree).Sin * uor,
                    Z = 0,
                };
                pnts.Add(pnt);
            }

            // 节点 = 控制点+阶数
            List<double> knots = new List<double>()
            {
                1,1,2,2,3,3,4,4,5,5
            };

            var bspline = BsplineCurve.CreateFromPoles(pnts, knots, 3, false);
            DraftingElementSchema.ToElement(dgnModel, bspline, null)?.AddToModel();
        }

        [MSTest("bClose")]
        public static void TestClosedBspine(string unparsed)
        {
            var dgnModel = Session.Instance.GetActiveDgnModel();
            var uor = dgnModel.GetModelInfo().UorPerMeter;

            List<DPoint3d> pnts = new List<DPoint3d>();
            List<double> degrees = new List<double>()
            {
                0,45,90,135,180,225,270 // 7 个
            };

            foreach (var degree in degrees)
            {
                DPoint3d pnt = new DPoint3d()
                {
                    X = Angle.FromDegrees(degree).Cos * uor,
                    Y = Angle.FromDegrees(degree).Sin * uor,
                    Z = 0,
                };
                pnts.Add(pnt);
            }

            // 节点 = 控制点+2*阶数-1
            List<double> knots = new List<double>()
            {
                1,2,3,4,5,6,7,8,9,10,11,1,2,3
            };

            var bspline = BsplineCurve.CreateFromPoles(pnts, knots, 4, true);
            var bknots = bspline.Knots();
            DraftingElementSchema.ToElement(dgnModel, bspline, null)?.AddToModel();
        }
    }
}
