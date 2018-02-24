using ASPNET_MVC5.Infrastructure;
using ASPNET_MVC5.Models.DTO;
using ASPNET_MVC5.Models.Input;
using ASPNET_MVC5.Models.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_MVC5.Controllers
{
    public class CandidatoController : Controller
    {
        string baseUrl = ConfigurationManager.AppSettings["serviceBaseURL"];

        public async Task<ActionResult> List()
        {
            ClearCreateCandidatoSession();
            ClearUpdateCandidatoSession();

            RESTClient client = new RESTClient(baseUrl);

            var response = await client.Get<IEnumerable<CandidatoListViewModel>>("api/Candidato");

            return View(response);
        }



        public ActionResult Create()
        {
            ClearCreateCandidatoSession();

            return RedirectToAction("CreateInformacoesDeContato");
        }


        public ActionResult CreateInformacoesDeContato()
        {
            if (Session["CreateInformacoesDeContato"] != null)
            {
                return View((InformacoesDeContatoInputModel)Session["CreateInformacoesDeContato"]);
            }
            return View();
        }

        [HttpPost]
        public ActionResult CreateInformacoesDeContato(InformacoesDeContatoInputModel model)
        {
            if (ModelState.IsValid)
            {
                Session["CreateInformacoesDeContato"] = model;

                return RedirectToAction("CreatePreferenciasDeTrabalho");
            }
            else
            {
                return View(model);
            }
        }



        public ActionResult CreatePreferenciasDeTrabalho()
        {
            if (Session["CreatePreferenciasDeTrabalho"] != null)
            {
                return View((PreferenciasDeTrabalhoInputModel)Session["CreatePreferenciasDeTrabalho"]);
            }
            return View();
        }

        [HttpPost]
        public ActionResult CreatePreferenciasDeTrabalho(PreferenciasDeTrabalhoInputModel model)
        {
            if (ModelState.IsValid)
            {
                Session["CreatePreferenciasDeTrabalho"] = model;

                return RedirectToAction("CreateQuestionarioDeHabilidades");
            }
            else
            {
                return View(model);
            }
        }



        public ActionResult CreateQuestionarioDeHabilidades()
        {
            if (Session["CreateQuestionarioDeHabilidades"] != null)
            {
                return View((QuestionarioDeHabilidadesInputModel)Session["CreateQuestionarioDeHabilidades"]);
            }
            return View();
        }

        [HttpPost]
        public ActionResult CreateQuestionarioDeHabilidades(QuestionarioDeHabilidadesInputModel model)
        {
            if (ModelState.IsValid)
            {
                Session["CreateQuestionarioDeHabilidades"] = model;

                return RedirectToAction("CreateInformacoesParaPagamento");
            }
            else
            {
                return View(model);
            }
        }



        public ActionResult CreateInformacoesParaPagamento()
        {
            if (Session["CreateInformacoesParaPagamento"] != null)
            {
                return View((InformacoesParaPagamentoInputModel)Session["CreateInformacoesParaPagamento"]);
            }
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateInformacoesParaPagamento(InformacoesParaPagamentoInputModel model)
        {
            if (ModelState.IsValid)
            {
                Session["CreateInformacoesParaPagamento"] = model;

                try
                {
                    var candidatoDTO = new CandidatoDTO(
                        (InformacoesDeContatoInputModel)Session["CreateInformacoesDeContato"],
                        (PreferenciasDeTrabalhoInputModel)Session["CreatePreferenciasDeTrabalho"],
                        (QuestionarioDeHabilidadesInputModel)Session["CreateQuestionarioDeHabilidades"],
                        (InformacoesParaPagamentoInputModel)Session["CreateInformacoesParaPagamento"]
                        );

                    RESTClient client = new RESTClient(baseUrl);
                    await client.PostJson<string>("api/Candidato", candidatoDTO);

                    ClearCreateCandidatoSession();

                    return View("CreateConcluido");
                }
                catch
                {
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }


        private void ClearCreateCandidatoSession()
        {
            Session["CreateInformacoesDeContato"] = null;
            Session["CreatePreferenciasDeTrabalho"] = null;
            Session["CreateQuestionarioDeHabilidades"] = null;
            Session["CreateInformacoesParaPagamento"] = null;
        }


        public async Task<ActionResult> Read(int id)
        {
            RESTClient client = new RESTClient(baseUrl);

            var response = await client.Get<CandidatoViewModel>($"api/Candidato/{id}");

            return View(response);
        }


        public async Task<ActionResult> Update(int id)
        {
            RESTClient client = new RESTClient(baseUrl);

            var response = await client.Get<CandidatoDTO>($"api/Candidato/{id}");
            Session["UpdateId"] = id;
            Session["UpdateInformacoesDeContato"] = new InformacoesDeContatoInputModel(response);
            Session["UpdatePreferenciasDeTrabalho"] = new PreferenciasDeTrabalhoInputModel(response);
            Session["UpdateQuestionarioDeHabilidades"] = new QuestionarioDeHabilidadesInputModel(response);
            Session["UpdateInformacoesParaPagamento"] = new InformacoesParaPagamentoInputModel(response);

            return RedirectToAction("UpdateInformacoesDeContato");
        }


        public ActionResult UpdateInformacoesDeContato()
        {
            if (Session["UpdateInformacoesDeContato"] != null)
            {
                return View((InformacoesDeContatoInputModel)Session["UpdateInformacoesDeContato"]);
            }
            return View();
        }

        [HttpPost]
        public ActionResult UpdateInformacoesDeContato(InformacoesDeContatoInputModel model)
        {
            if (ModelState.IsValid)
            {
                Session["UpdateInformacoesDeContato"] = model;

                return RedirectToAction("UpdatePreferenciasDeTrabalho");
            }
            else
            {
                return View(model);
            }
        }



        public ActionResult UpdatePreferenciasDeTrabalho()
        {
            if (Session["UpdatePreferenciasDeTrabalho"] != null)
            {
                return View((PreferenciasDeTrabalhoInputModel)Session["UpdatePreferenciasDeTrabalho"]);
            }
            return View();
        }

        [HttpPost]
        public ActionResult UpdatePreferenciasDeTrabalho(PreferenciasDeTrabalhoInputModel model)
        {
            if (ModelState.IsValid)
            {
                Session["UpdatePreferenciasDeTrabalho"] = model;

                return RedirectToAction("UpdateQuestionarioDeHabilidades");
            }
            else
            {
                return View(model);
            }
        }



        public ActionResult UpdateQuestionarioDeHabilidades()
        {
            if (Session["UpdateQuestionarioDeHabilidades"] != null)
            {
                return View((QuestionarioDeHabilidadesInputModel)Session["UpdateQuestionarioDeHabilidades"]);
            }
            return View();
        }

        [HttpPost]
        public ActionResult UpdateQuestionarioDeHabilidades(QuestionarioDeHabilidadesInputModel model)
        {
            if (ModelState.IsValid)
            {
                Session["UpdateQuestionarioDeHabilidades"] = model;

                return RedirectToAction("UpdateInformacoesParaPagamento");
            }
            else
            {
                return View(model);
            }
        }



        public ActionResult UpdateInformacoesParaPagamento()
        {
            if (Session["UpdateInformacoesParaPagamento"] != null)
            {
                return View((InformacoesParaPagamentoInputModel)Session["UpdateInformacoesParaPagamento"]);
            }
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> UpdateInformacoesParaPagamento(InformacoesParaPagamentoInputModel model)
        {
            if (ModelState.IsValid)
            {
                Session["UpdateInformacoesParaPagamento"] = model;

                try
                {
                    var Id = (int)Session["UpdateId"];
                    var candidatoDTO = new CandidatoDTO(
                        (InformacoesDeContatoInputModel)Session["UpdateInformacoesDeContato"],
                        (PreferenciasDeTrabalhoInputModel)Session["UpdatePreferenciasDeTrabalho"],
                        (QuestionarioDeHabilidadesInputModel)Session["UpdateQuestionarioDeHabilidades"],
                        (InformacoesParaPagamentoInputModel)Session["UpdateInformacoesParaPagamento"]
                        );

                    RESTClient client = new RESTClient(baseUrl);
                    await client.PutJson<string>($"api/Candidato/{Id}", candidatoDTO);

                    ClearUpdateCandidatoSession();

                    return View("UpdateConcluido", Id);
                }
                catch
                {
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }


        private void ClearUpdateCandidatoSession()
        {
            Session["UpdateId"] = null;
            Session["UpdateInformacoesDeContato"] = null;
            Session["UpdatePreferenciasDeTrabalho"] = null;
            Session["UpdateQuestionarioDeHabilidades"] = null;
            Session["UpdateInformacoesParaPagamento"] = null;
        }


        public async Task<ActionResult> Delete(int id)
        {
            RESTClient client = new RESTClient(baseUrl);

            var response = await client.Get<CandidatoViewModel>($"api/Candidato/{id}");

            return View(response);
        }


        [HttpPost]
        public async Task<ActionResult> Delete(CandidatoViewModel model)
        {
            try
            {
                RESTClient client = new RESTClient(baseUrl);
                await client.Delete<string>($"api/Candidato/{model.Id}");

                return View("DeleteConcluido", model.Id);
            }
            catch
            {
                return View(model);
            }
        }
    }
}
