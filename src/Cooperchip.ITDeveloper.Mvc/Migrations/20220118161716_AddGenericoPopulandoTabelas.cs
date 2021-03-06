using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cooperchip.ITDeveloper.Mvc.Migrations
{
    public partial class AddGenericoPopulandoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Generico",
                columns: new[] { "Id", "Codigo", "Nome" },
                values: new object[,]
                {
                    { new Guid("77170883-5f4f-4a92-bee2-155817ded452"), 386, "RIPE" },
                    { new Guid("3687247a-4898-4389-b297-960f1ab10dc4"), 264, "Nifedipina" },
                    { new Guid("99d55158-00df-48e4-9cee-c39ec864fb5d"), 263, "Nevirapina" },
                    { new Guid("38b7fd04-588d-4250-81d9-dba8daaa0c0e"), 262, "Neostigmina" },
                    { new Guid("b7042b61-541f-45bd-b16f-48b3bfb7f2ce"), 261, "Nelfinavir" },
                    { new Guid("9797944a-db80-4afa-8b08-da179a69723c"), 260, "Nebivolol" },
                    { new Guid("b86d6eae-14a4-45bd-96a8-808a821ceae1"), 259, "Naloxona" },
                    { new Guid("a9b0f368-2bb0-44b0-9039-32529a57f59a"), 258, "Nalbufina" },
                    { new Guid("ae1d0e70-6901-41de-a4de-ec62d4b59758"), 257, "NaCl" },
                    { new Guid("dccac0d3-7e93-4250-b92a-792512cf5eef"), 256, "N-Acetilciste�na" },
                    { new Guid("011c0d36-4320-42a9-9c31-8ed71a6d1de9"), 265, "Nifepidina" },
                    { new Guid("bced6f05-4223-42bb-bdf3-f6d72a0361ce"), 255, "Mupirocin" },
                    { new Guid("a81d513f-afb6-4011-ab06-5a82bc964fc1"), 253, "Morfina" },
                    { new Guid("b9f77ff4-1a30-4577-b805-620bcf25c50c"), 252, "Mononitrato de Isossorbida" },
                    { new Guid("eee585ef-97ea-4931-bfb2-9a134b8de099"), 251, "Milrinona" },
                    { new Guid("bce57825-f050-488c-81e7-9fee172c22ac"), 250, "Midazolam" },
                    { new Guid("8d3b2aec-3f79-4538-a4c3-89d051633d6d"), 249, "Metronidazol" },
                    { new Guid("f74de63a-6c26-470a-a91c-c2e0bcd2412e"), 248, "Metotrexate" },
                    { new Guid("01b11a41-4379-4d86-926f-33531a28a55f"), 247, "Metoprolol" },
                    { new Guid("3c8f0ab3-24d2-4d0b-89b6-ee83593ce90f"), 246, "Metoclopramida" },
                    { new Guid("61cf6d9b-381a-488e-a37e-a234e77d3c92"), 245, "Metimazol" },
                    { new Guid("4a34fbbb-3ddc-43f3-8948-691e1f3092a4"), 254, "Moxifloxacina" },
                    { new Guid("6e3969fa-0f3f-4443-82bb-3974cfeb7305"), 244, "Metilprednisolona" },
                    { new Guid("e4ee3af1-f75f-4461-973c-ddea27917637"), 266, "Nimesulida" },
                    { new Guid("f324663c-f806-4e1f-be61-1bafe9a42584"), 268, "Nistatina" },
                    { new Guid("714e1d64-1772-4fcd-8a27-c3d99c556fb3"), 288, "Paracetamol" },
                    { new Guid("ad994ab6-2681-477d-8fc5-1318e702ac88"), 287, "Pantoprazol" },
                    { new Guid("96ada52e-de75-4445-8a90-fb0f4e990e9b"), 286, "Pancur�nio" },
                    { new Guid("698a1bdb-7c92-4ecd-86d6-7a212d009e65"), 285, "Oxig�nio" },
                    { new Guid("5fa9953a-7c73-458a-aea2-1c048f7f9a4c"), 284, "Oxacilina" },
                    { new Guid("bf4fb3ba-4692-474b-99c3-91c2cffc5498"), 283, "Oseltamivir" },
                    { new Guid("75ef0550-b7b6-48ee-93af-2f8b36948956"), 282, "Orlistate" },
                    { new Guid("658172f2-9471-486e-8308-89e5262f344f"), 281, "Ondansetrona" },
                    { new Guid("3f660592-b6c8-4c3e-bd40-a97b53066890"), 280, "Omeprazol" },
                    { new Guid("23c728b2-425a-4827-8773-164c5da2cf65"), 267, "Nimodipina" },
                    { new Guid("d8c991ea-4b54-4580-af80-eae5fe59072a"), 279, "�leo Mineral" },
                    { new Guid("8bf05a82-8046-4c68-acd3-4cc46910a6bf"), 277, "Octreotida" },
                    { new Guid("3ae5b9fd-1030-4d71-a938-ddaa5e39def3"), 276, "Ocitocina" },
                    { new Guid("8859f8eb-b061-457a-bbd5-41f2f2603e17"), 275, "Nutri��o Parenteral Total" },
                    { new Guid("a1a56178-a71e-40b9-b762-c6be04e56e56"), 274, "Nortriptilina" },
                    { new Guid("528e42a8-d1f5-4735-a4fb-d745406d2cdc"), 273, "Norfloxacina" },
                    { new Guid("5b32a049-8782-4510-951e-b9a2044bf725"), 272, "Noradrenalina" },
                    { new Guid("a33bb8a1-2a29-4b59-91f8-58d5573a4cf8"), 271, "Nitroprussiato de S�dio" },
                    { new Guid("ce308a4d-e3c1-46fd-9997-b86787b4353f"), 270, "Nitroglicerina" },
                    { new Guid("b3478139-6f6a-43c8-9b32-b87eb5430547"), 269, "Nitrendipina" },
                    { new Guid("75036e32-d3ba-426a-be85-7a0f6576c6b6"), 278, "Octreotide" },
                    { new Guid("71b1ac79-c857-4e73-b37f-b75e9f199763"), 289, "Paroxetina" },
                    { new Guid("37229154-a999-4519-b9a9-21b7e0a290af"), 243, "Metildopa" },
                    { new Guid("09c0b0eb-fe90-478f-ab43-0c9877163ee6"), 241, "Metadona" },
                    { new Guid("3beca4d8-d474-4aa8-bccc-9f23f8b7a255"), 216, "Levodopa" },
                    { new Guid("88c49779-86fe-4b20-9989-efce1d3659ba"), 215, "Lansoprazol" },
                    { new Guid("46393711-169d-481d-a085-d79406a42aac"), 214, "Lamivudina-Zidovudina" },
                    { new Guid("be8996a3-ca9e-4e29-b061-293e22deb17f"), 213, "Lamivudina" },
                    { new Guid("a6900682-0132-4ef7-b19c-ae45585a334d"), 212, "Lactulose" },
                    { new Guid("c280bef4-9e81-4544-bf8a-eb774b9e11b9"), 211, "Labetalol" },
                    { new Guid("955f2a15-a54d-425d-9406-d4d2a996f5d6"), 210, "Ketamina" },
                    { new Guid("addd86f7-0ef5-49f0-91d1-004e24d2f485"), 209, "KCl" },
                    { new Guid("85b23611-bdee-417d-8a3a-6bbaa07bf443"), 208, "Ivermectina" },
                    { new Guid("22bb5533-d5fb-4f3b-b837-8a6f309c7d90"), 217, "Levodopa/Carbidopa" },
                    { new Guid("e928d351-57cc-47af-8cda-0ea7f5a16a84"), 207, "Itraconazol" },
                    { new Guid("66f30a6d-8a68-4998-ad2e-de55e31e0110"), 205, "Insulina" },
                    { new Guid("5a8eb632-2944-484a-9166-2337d1db9433"), 204, "Inibidores da Protease" },
                    { new Guid("c2c65d46-80aa-49bc-ab3f-275421c740d5"), 203, "Inibidores da Anidrase Carb�nica" },
                    { new Guid("11ef5942-39f9-4d0f-9a0e-1ef831e3f722"), 202, "Indometacina" },
                    { new Guid("0dacf202-11e6-44dc-bd09-17dcc88fabb7"), 201, "Indinavir" },
                    { new Guid("315e693c-b4b2-4a68-8297-fafcca51b42f"), 200, "Indapamida" },
                    { new Guid("52b120bd-252d-424c-ace7-eec63ba6dc73"), 199, "Imipramina" },
                    { new Guid("d50e268d-1ba7-4a1b-aa6a-8aa74e558593"), 198, "Imipenem" },
                    { new Guid("44e1fb85-7214-43b9-a8d1-60ad0e26f298"), 197, "Ibuprofeno" },
                    { new Guid("66b30a5c-1544-4037-a4c6-8fc7dc8bce1f"), 206, "Isoniazida" },
                    { new Guid("d88af483-dae1-49c9-aafc-bac526ecce1b"), 242, "Metformina" },
                    { new Guid("22142289-2853-4479-aaa2-d7aba09492dc"), 218, "Levodopa-Carbidopa" },
                    { new Guid("69199f2d-53ac-42ea-9fcd-232e6f6d29b3"), 220, "Levomepromazina" },
                    { new Guid("bd613d54-f498-41e9-812c-af196784cfcd"), 240, "Mesalazina" },
                    { new Guid("4c2ff676-69d8-48f2-a7f8-0676f92733da"), 239, "Meropenem" },
                    { new Guid("345252c0-99aa-4827-a48b-e4f00ddee44c"), 238, "Meperidina" },
                    { new Guid("befa1c9b-7324-4312-89ad-f6e362b2291e"), 237, "Mefloquina" },
                    { new Guid("3e031227-dd7a-4fc7-96d8-f47adde83dfb"), 236, "Mebendazol" },
                    { new Guid("728965ce-3fd9-4647-b52e-8799a4f72a94"), 235, "Manitol" },
                    { new Guid("b6e56824-701d-4c41-bec8-2867cb80e6a4"), 234, "Lovastatina" },
                    { new Guid("4d6282c3-e5ec-412a-b5ed-bd30234581a3"), 233, "Losartan" },
                    { new Guid("1481d34a-24fc-4fab-b4d9-ae1f6bcef311"), 232, "Lorazepan" },
                    { new Guid("fdc26062-dfb2-4800-9a7f-d78910a65221"), 219, "Levofloxacina" },
                    { new Guid("db21834c-3fbe-43f7-b060-99b21cd0bbff"), 231, "Lorazepam" },
                    { new Guid("02ec153d-88b7-44b7-99e3-8b0fbe7998ce"), 229, "Lopinavir-r" },
                    { new Guid("2330c85b-0628-4783-ac42-3f89e93af006"), 228, "Lopinavir/r" },
                    { new Guid("acef0f7d-1034-4417-800b-11029ed2a64e"), 227, "Loperamida" },
                    { new Guid("5e4969ff-5d1c-4ada-98d5-80a04365eb07"), 226, "L�tio" },
                    { new Guid("b991c4ec-05e5-455f-bb09-1c7e74228a45"), 225, "Lisinopril" },
                    { new Guid("73d5f8c8-f9e5-4d63-95e0-f40bf6ba373b"), 224, "Linezolida" },
                    { new Guid("dc7a95ec-7867-457c-8bda-70d9458c9d72"), 223, "Lidoca�na" },
                    { new Guid("5a5ebcf2-b920-4b55-a481-1a556fe34c7a"), 222, "Levotiroxina" },
                    { new Guid("e5c6c236-2094-418d-ac93-0b9af5329b97"), 221, "Levosimendam" },
                    { new Guid("2f8c64cb-010e-471c-b405-1d61201211b8"), 230, "Loratadina" },
                    { new Guid("cba7311f-ebdc-47d6-99b0-b7e5ca4332cc"), 290, "Penicilina G" },
                    { new Guid("cc80e63e-aa85-48bd-a32d-acf6e4a877d8"), 291, "Pentamidina" },
                    { new Guid("6378d87a-d5fd-465e-a729-92b2d1cc5951"), 196, "Hypericum perfuratum" },
                    { new Guid("7baa1b14-e48f-4871-9b18-3cc1be37c4a3"), 361, "Tirofiban" },
                    { new Guid("fff5ec5a-58f3-4f2f-bf0b-c0050ae8758f"), 360, "Tipranavir" },
                    { new Guid("8fa2b25d-c40a-4c35-8dd4-6f623ff20a5c"), 359, "Tiopental" },
                    { new Guid("a3978e3f-02bc-4382-8f32-10984112d4fd"), 358, "Tinidazol" },
                    { new Guid("d94e55de-9dea-4c4a-ad94-d4b2bedac62e"), 357, "Timolol" },
                    { new Guid("b1d88b8c-9d44-4008-8366-12aed092964d"), 356, "Tigeciclina" },
                    { new Guid("725a38db-08a5-47cf-9481-97d88159b668"), 355, "Ticlopidina" },
                    { new Guid("d134a546-14ef-46f7-a2b5-043deeb20338"), 354, "Ticarcilina-clavulanato" },
                    { new Guid("b8ec9b43-20f1-48d9-afef-c24a28205b18"), 353, "Ticarcilina" },
                    { new Guid("1a52bca4-ca36-4cb9-bd93-6ce64ea747bc"), 362, "Tobramicina" },
                    { new Guid("d79a9727-3d00-4786-916b-f63835dbd501"), 352, "Tiaz�dicos" },
                    { new Guid("26fdbed0-6e62-4142-ba4e-ac1535d6ba37"), 350, "Terfenadina" },
                    { new Guid("dd0fd3b7-b1be-4f0a-845e-2093c7e4b0ad"), 349, "Tenoxicam" },
                    { new Guid("d78f559f-2757-403a-8afe-90fe9604ad3e"), 348, "Teicoplanina" },
                    { new Guid("09ae1ace-cd60-4cc1-ad3c-9233d3833222"), 347, "Tamarine" },
                    { new Guid("b9aed972-40ed-4205-abc4-8defbec22263"), 346, "Sulfato Ferroso" },
                    { new Guid("427abf07-38fa-4982-b175-00f43882bee0"), 345, "Sulfato de Magn�sio" },
                    { new Guid("d2f083d7-e190-4571-8962-13f7b235f6be"), 344, "Sulfassalazina" },
                    { new Guid("06309eca-d4fa-4e81-8f1a-5a362c85087b"), 343, "Sulfametoxazol-Trimetoprim" },
                    { new Guid("f30690bc-2c5b-4bc0-b2e4-78f5d1ae6017"), 342, "Sucralfato" },
                    { new Guid("33ed3d1d-97d3-4994-8d9b-e2b339120e6f"), 351, "Tiabendazol" },
                    { new Guid("38f28122-b93d-4f26-961f-6a88c6b789e7"), 341, "Succinilcolina" },
                    { new Guid("e985bf28-7b05-43e0-b170-a6e9e928f0fa"), 363, "Tramadol" },
                    { new Guid("176e4930-af73-4a06-bef0-f88083a9a8c4"), 365, "Tric�clicos" },
                    { new Guid("97f359ef-aa5d-47d4-9052-720a277cc3df"), 385, "Zidovudina" },
                    { new Guid("d955b73a-71a3-4372-b15d-da81828a8e9d"), 384, "Warfarin" },
                    { new Guid("8fabd160-d98e-44bc-a13e-799731c1177d"), 383, "Voriconazol" },
                    { new Guid("c6421736-47c5-447d-bbf2-dd61edb95cf3"), 382, "Vitamina K" },
                    { new Guid("dbdfac39-f871-4d46-b414-92eb22bf8476"), 381, "Vitamina E" },
                    { new Guid("123c0262-8536-41dc-be64-1185fa2b653b"), 380, "Vitamina D" },
                    { new Guid("5cd87226-8649-46cc-b971-20b11f725560"), 379, "Vitamina C" },
                    { new Guid("ab1a01c1-f901-4c37-a629-e7faacb55cc6"), 378, "Vitamina B6" },
                    { new Guid("57ca5a17-234b-4127-b1b3-e8792d063e30"), 377, "Vitamina B12" },
                    { new Guid("a8b72f0d-4382-422c-b6b0-82e45d714fb2"), 364, "Trazodona" },
                    { new Guid("d33c5bf4-fedf-4ac0-ae42-9144748bdb7c"), 376, "Vitamina B1" },
                    { new Guid("f7e5d366-d14d-4f32-8e08-51cf24314d1f"), 374, "Veparamil" },
                    { new Guid("679a6d13-5a55-4a98-92c1-8c61a1925ded"), 373, "Venlafaxina" },
                    { new Guid("85a048f2-5402-41b6-985f-9d1e3aec8816"), 372, "Vecur�nio" },
                    { new Guid("ac30ae87-5c47-4bfe-83de-df5852f1f437"), 371, "Vasopressina" },
                    { new Guid("d96a6c39-c138-4c49-bacf-082303e8d2d4"), 370, "Vancomicina" },
                    { new Guid("52d0dd5d-e434-4fb8-bac3-19c47a559002"), 369, "Valsartan" },
                    { new Guid("ef2c30a2-515e-4d23-89f5-cfd826a45bea"), 368, "Valaciclovir" },
                    { new Guid("7375d60d-f5fd-4314-beb0-2768ae17c408"), 367, "Troglitazona" },
                    { new Guid("0b569284-83d1-4d06-af18-4fc1b9bc7b9a"), 366, "Trimetazidina" },
                    { new Guid("ddcb3769-230e-4b32-bf0d-98aa54228f8d"), 375, "Verapamil" },
                    { new Guid("ffe9bf89-57e3-471f-b33b-db5fbf603d1a"), 340, "Sotalol" },
                    { new Guid("39ab5dde-0fcb-478d-82b0-691be3195cf9"), 339, "Sinvastatina" },
                    { new Guid("2616d5f4-258b-4b6c-9793-dac8bc417d7c"), 338, "Sildenafil" },
                    { new Guid("2fd774d5-bcfe-41fc-88d7-0fd07fe547b8"), 312, "Propofol" },
                    { new Guid("82fe630d-79bc-4153-9bc0-43df91170b84"), 311, "Propiltiouracil" },
                    { new Guid("c8a1fce6-a88b-4f71-9fee-e4ec54c173fd"), 310, "Propatilnitrato" },
                    { new Guid("71a8fb5a-c8f1-49a0-94a0-342b413e1522"), 309, "Propafenona" },
                    { new Guid("37b4a8a4-6f2a-438c-acd4-eacc48aa1c60"), 308, "Prometazina" },
                    { new Guid("dfe07af7-e5a8-4d74-800a-ddec931b227f"), 307, "Procainamida" },
                    { new Guid("804f30d8-c237-4173-ac46-233ff0370972"), 306, "Primidona" },
                    { new Guid("c89b24dc-d68d-44c5-bbf3-068ab3efdba3"), 305, "Prednisona" },
                    { new Guid("a00e5e00-d76c-42a3-b0dc-0034f0f1c6b3"), 304, "Prednisolona" },
                    { new Guid("17cd2f74-636e-4aaa-98b0-ec2ad2b42e95"), 313, "Propranolol" },
                    { new Guid("5669a8da-b947-4c56-b706-1e9ae84a1e93"), 303, "Pravastatina" },
                    { new Guid("036a95c7-b77d-448b-8c6a-dd4952f7f1de"), 301, "Polimixina B" },
                    { new Guid("05ead0ae-0a45-4493-9195-ee8f87b9f48f"), 300, "Plasma fresco congelado" },
                    { new Guid("98ea68d5-a1c4-4b47-addd-149fe6564cf2"), 299, "Pitavastatina" },
                    { new Guid("c1e7b8f6-c5c7-4633-9251-f4c0e197b6d6"), 298, "Piroxicam" },
                    { new Guid("5b3f712c-0ae5-443b-bf8f-225ae691cb23"), 297, "Pirimetamina" },
                    { new Guid("d7984e26-df8a-442f-9016-9e51b1b1548a"), 296, "Piridostigmina" },
                    { new Guid("896666fd-755a-482a-aa90-040ee5e4a33c"), 295, "Pirazinamida" },
                    { new Guid("89a0f91c-f144-4aae-8cd1-107a9aa4cf42"), 294, "Piperacilina-tazobactam" },
                    { new Guid("a9c8ee1c-d3dd-4c67-83f3-1b8251a0b7f8"), 293, "Pentoxifilina" },
                    { new Guid("39dace15-be42-4a81-b488-8f64db773dce"), 302, "Posaconazol" },
                    { new Guid("f4f51ac6-0d69-498d-85ee-17f5041a4a11"), 314, "Protamina" },
                    { new Guid("81d1ad63-2d2e-4141-bd12-c6eb72142b5f"), 315, "Quinidina" },
                    { new Guid("d41c58b5-b5b5-4002-ae95-9482632d0e0e"), 316, "Quinina" },
                    { new Guid("23f82c31-a854-4e30-88a1-69557cea70fd"), 337, "Sertralina" },
                    { new Guid("1ead72da-880b-4eac-a91b-baab35f3de07"), 336, "Secnidazol" },
                    { new Guid("ebd7e831-b6b2-4f0e-af82-6206f41491cb"), 335, "Saquinavir" },
                    { new Guid("f530d380-f9b5-4ea3-bed9-6c245f00fc9c"), 334, "Salbutamol" },
                    { new Guid("8f732d26-c0d7-4a09-8976-68f66cf93c33"), 333, "rtPA" },
                    { new Guid("2c7589f2-b07b-4903-a3c4-7e8dff2b5e69"), 332, "Rosuvastatina" },
                    { new Guid("f3154c72-a585-4462-8f3e-20f2b144a84c"), 331, "Rosiglitazona" },
                    { new Guid("2b231533-e8ce-45fa-aabd-826da2a7dedf"), 330, "Rivastigmina" },
                    { new Guid("ab7f3daa-7656-41af-83d8-5e0749b5b327"), 329, "Rivaroxabana" },
                    { new Guid("f6dc3c0b-343c-41f1-bf62-13510031f8ec"), 328, "Ritonavir" },
                    { new Guid("8fdc385f-4d31-4ce2-8f0a-7aba22aa12da"), 327, "Risperidona" },
                    { new Guid("ead054b2-7ac3-4031-a5f4-7462b8dab2f0"), 326, "Ringer Simples" },
                    { new Guid("dd35ae45-f62e-4d94-9ced-34be81ed7368"), 325, "Ringer Lactato" },
                    { new Guid("27339396-56ba-4d2f-a4f3-4c67ccf63b15"), 324, "Rifampicina-Isoniazida" },
                    { new Guid("40bda76b-46a3-4abc-94a2-469467dcdf71"), 323, "Rifampicina" },
                    { new Guid("d61ac4cc-299d-454b-8e2a-56ab6d999f0c"), 322, "Rifabutina" },
                    { new Guid("37bff921-4f7a-4f18-8e81-f62c5da5424a"), 321, "Repaglinida" },
                    { new Guid("9ad2f945-63d4-4ff3-90fe-d94bae12348c"), 320, "Ranitidina" },
                    { new Guid("35e96760-8d40-4ca4-8d4f-cd8e9ad0aa99"), 319, "Ramipril" },
                    { new Guid("cb053b49-52bd-4aff-aebf-90e0b337aad3"), 318, "Quinupristina-dalfopristina" },
                    { new Guid("17bb5916-9ac0-400a-9b8a-dc4e35a11e6a"), 317, "Quinolonas" },
                    { new Guid("50129c48-3dc3-4a96-ab58-b5b8ae2f41d7"), 387, "Curativo" },
                    { new Guid("4ae6aff0-33a0-4919-9e4e-e1d29f564a9f"), 292, "Pentobarbital" },
                    { new Guid("88fe6196-85a6-4f79-8d8e-44c6d6e42991"), 195, "Hisoscel" },
                    { new Guid("6943f532-b90c-449a-b743-6c957270e3c8"), 193, "Hioscina-Dipirona" },
                    { new Guid("93fd72c2-6ee8-4cb0-a5ff-a771cbcd1701"), 70, "Cefalexina" },
                    { new Guid("bb96989b-b941-4a45-9072-f131a6e6efbe"), 69, "Cefadroxil" },
                    { new Guid("aad3b0bf-1ccf-4f15-8227-9355fa4e4cb2"), 68, "Cefaclor" },
                    { new Guid("ed869de7-72ef-4a87-81ab-063b09c6fa0a"), 67, "Caspofungina" },
                    { new Guid("2c5f4ea9-7a12-42aa-8a01-63f6e801a689"), 66, "Carvedilol" },
                    { new Guid("22fb433e-da77-477d-9365-4088ab8c2f72"), 65, "Carbamazepina" },
                    { new Guid("a6cdfd90-b922-458a-840e-7544a6140195"), 64, "Captopril" },
                    { new Guid("1d2e46d7-d2d4-4a50-bc9b-18268e9a0ad2"), 63, "Buspirona" },
                    { new Guid("cd99d668-9191-4f3a-bc72-454bf3d90646"), 62, "Bupivaca�na" },
                    { new Guid("304b8e50-7ec7-4bb0-a60f-590a5f52719d"), 71, "Cefalotina" },
                    { new Guid("76745401-28a5-45ff-b2c6-58179f230a80"), 61, "Bromoprida" },
                    { new Guid("712d9e13-647d-42f3-912c-4cac0e800831"), 59, "Bisoprolol" },
                    { new Guid("6309f33f-7857-479b-a8db-e6f3acd925d0"), 58, "Bisacodil" },
                    { new Guid("23f6ca6c-c116-4da3-a77c-877a3f1a8f6b"), 57, "Biperideno" },
                    { new Guid("7d46d470-05a5-43cd-ac49-388ab77210aa"), 56, "Bicarbonato de S�dio" },
                    { new Guid("ab2f143c-89fa-4bef-8669-b22c16c55d7a"), 55, "Bezafibrato" },
                    { new Guid("f4ccac05-44a7-4b44-b9d4-0d0ba7a699dd"), 54, "Betametasona" },
                    { new Guid("ffd005a6-942c-4221-a0f3-8bc456754dee"), 53, "Betabloqueadores" },
                    { new Guid("d9b498f2-12dd-4d90-88bb-f261fd028a45"), 52, "Benzoato de Benzila" },
                    { new Guid("7704b142-8de6-465f-ad6a-111963b43fc1"), 51, "Bamifilina" },
                    { new Guid("a0c10bf6-c08c-4688-891c-79da32353106"), 60, "Bromazepam" },
                    { new Guid("5dc8f33f-14cc-4a5d-903f-02f94b0d43df"), 50, "Baclofeno" },
                    { new Guid("3f4c3753-f1ef-4e96-b945-f3a461996ec0"), 72, "Cefazolina" },
                    { new Guid("eca93f53-5906-4916-b183-e63e84884558"), 74, "Cefotaxima" },
                    { new Guid("f19d2f37-7899-420f-9591-0839ed3679be"), 94, "Clonidina" },
                    { new Guid("0549c1c1-b05d-461b-a92a-54d963c5c984"), 93, "Clonazepam" },
                    { new Guid("e2a08ba8-1fcc-40ed-ad25-1650de81b98c"), 92, "Clofibrato" },
                    { new Guid("96d7f8f2-381e-4d5b-ada9-01a4b8452294"), 91, "Clindamicina" },
                    { new Guid("6000af25-1f26-4c6b-8bb9-945fc01e859f"), 90, "Claritromicina" },
                    { new Guid("70f988c6-a3c0-48df-9909-acfacd506c4d"), 89, "Citalopram" },
                    { new Guid("1da789d8-2201-4d6c-8ecb-f4a91987722f"), 88, "Cisaprida" },
                    { new Guid("30ebfb2d-d45f-4ede-9987-2ceaf7c0ee58"), 87, "Ciprofloxacina" },
                    { new Guid("e678f32a-391d-44a8-b92e-0f89128cb95e"), 86, "Cinarizina" },
                    { new Guid("b87b2201-2a78-4658-9f3c-9eef5f159e9e"), 73, "Cefepima" },
                    { new Guid("5baf107a-1650-46be-98a3-affe47e2481c"), 85, "Cimetidina" },
                    { new Guid("bc716e22-8659-46d1-afd6-e7b14c984a36"), 83, "Ciclosporina" },
                    { new Guid("8c3a598f-7917-42ce-b1bc-64f72d0fe5eb"), 82, "Cetorolaco" },
                    { new Guid("b2f90be3-3554-46a2-a38c-5d13fd4a24be"), 81, "Cetoprofeno" },
                    { new Guid("d0f8aa3b-5dbf-4110-9faf-c9f04d98ec78"), 80, "Cetoconazol" },
                    { new Guid("48d21dc7-fd9e-426e-84bb-e6ec617393b4"), 79, "Celecoxibe" },
                    { new Guid("ca5d513d-add8-455f-8fc0-7b02140ba781"), 78, "Cefuroxima" },
                    { new Guid("3b3795b8-1ece-4f18-8251-47a09e2c62bb"), 77, "Ceftriaxona" },
                    { new Guid("b0bbf840-b48c-4510-81a5-01c90a12c953"), 76, "Ceftazidima" },
                    { new Guid("a403d7df-ca4c-4bb1-9e20-47b3bc76db49"), 75, "Cefpiroma" },
                    { new Guid("d2cbecc6-f704-4562-a94b-8d99ee97ac41"), 84, "Cilostazol" },
                    { new Guid("ebc9b41a-fe44-4e9a-a093-586a3ffa865e"), 49, "Aztreonam" },
                    { new Guid("42c7fe8c-c5ed-4ed3-b0fb-f92dc1cb70ba"), 48, "Azitromicina" },
                    { new Guid("5c4bcba1-060f-4f48-9b3b-62c6f4a6e3d2"), 47, "Atropina" },
                    { new Guid("6e776313-1ba5-48ab-b1ad-f42d1d49b090"), 21, "Alprazolam" },
                    { new Guid("c14fe88f-1e89-41dd-ac04-1cab2c8ddd3b"), 20, "Alopurinol" },
                    { new Guid("7327222f-2454-4529-9e01-a16210751a98"), 19, "Alfentanil" },
                    { new Guid("67d46f5c-583a-46b4-b86a-2f36375f4dcf"), 18, "Albumina" },
                    { new Guid("3d3fd783-440a-4ff1-afe7-a00c958e339f"), 17, "Albendazol" },
                    { new Guid("b1fc0208-3c39-4b9f-be58-44bb438373d0"), 16, "AINEs" },
                    { new Guid("97fb7de3-cde7-4d17-900b-9c9350fecd63"), 15, "�gua" },
                    { new Guid("1a088480-1d3e-45ad-a4b9-a4cdb9f1351a"), 14, "AGE" },
                    { new Guid("fcee94b9-07f0-49c5-a685-6e77b6ede6cb"), 13, "Adrenalina" },
                    { new Guid("2c02f64a-8970-44f2-98d2-f14b32f699ea"), 22, "Alteplase" },
                    { new Guid("84af5763-ef00-4423-a99c-625d27bb9885"), 12, "Adenosina" },
                    { new Guid("89a8db44-abf4-4d28-902b-dbd627f58565"), 10, "�cido Tranex�mico" },
                    { new Guid("1c48a1e1-6a89-4a8b-959f-6f3e4c22aa91"), 9, "�cido Nicot�nico" },
                    { new Guid("e586a2c5-aed0-4f3c-85d7-707d7c51d4f3"), 8, "�cido Fol�nico" },
                    { new Guid("0d40e31b-a9d0-4250-b2e6-e7707991ca07"), 7, "�cido F�lico" },
                    { new Guid("62bb0cc8-93db-41f8-bfdb-98737a152372"), 6, "�cido Acetilsalic�lico" },
                    { new Guid("14ea430e-a2ee-43d3-9b36-d391687d9d49"), 5, "Aciclovir" },
                    { new Guid("29ea5ad7-9f34-4f60-bbd7-d82043530a34"), 4, "Acetazolamida" },
                    { new Guid("a041d942-4ba1-41dd-800d-705b384e7531"), 3, "Acarbose" },
                    { new Guid("fa688c77-1209-45af-b43f-f854d470058f"), 2, "Abciximab" },
                    { new Guid("b82f3ca3-075a-4321-8d3d-46131c280145"), 11, "�cido Valpr�ico" },
                    { new Guid("9a97ecf4-bea0-4f83-982b-9650e232ee7c"), 23, "Amantadina" },
                    { new Guid("bb44ed75-cb3f-4f1d-8569-fb9a6d528be8"), 24, "Ambroxol" },
                    { new Guid("3be1f0fe-788f-4dc3-a142-1b6db7fbcfe6"), 25, "Amicacina" },
                    { new Guid("f754785b-b84e-4d6c-b807-777552257830"), 46, "Atrac�rio" },
                    { new Guid("206345b0-6f2f-4b2d-9504-e8a96dac9636"), 45, "Atovaquona" },
                    { new Guid("0bd95ec3-9e38-499d-907f-df4e258d645d"), 44, "Atorvastatina" },
                    { new Guid("2bf29410-f57d-4e47-bf0e-9576c1f336eb"), 43, "Atenolol" },
                    { new Guid("07a84899-b763-4705-8eaa-8618662eca78"), 42, "Atazanavir" },
                    { new Guid("2e01f43e-d47d-444c-858c-5454103603cb"), 41, "Astemizol" },
                    { new Guid("3e0b0a41-7e9d-4c9a-b2c4-d0b0f19c6e14"), 40, "Antipsic�ticos" },
                    { new Guid("338646e0-6fa1-4cbc-98f6-979bf780bd7d"), 39, "Antiparkinsonianos" },
                    { new Guid("bce00be8-9d88-4510-a853-2bb883a38b9c"), 38, "Antiarr�tmicos" },
                    { new Guid("b66b0f32-00b5-4000-9b57-37dbef343259"), 37, "Anlodipina" },
                    { new Guid("a214b112-1d3b-470e-a8f1-04d60c1c959b"), 36, "Anfotericina B" },
                    { new Guid("50d923a6-6c9a-4844-83e7-21131627105f"), 35, "Anest�sicos gerais" },
                    { new Guid("2a4557d8-372c-4d66-a3d0-39b90e621668"), 34, "Amrinona" },
                    { new Guid("63857434-a020-46c5-b66c-f91665fa16c9"), 33, "Amprenavir" },
                    { new Guid("93b2fb97-eedc-42fe-8acd-ebf59f99bc17"), 32, "Ampicilina-sulbactam" },
                    { new Guid("729c5440-25aa-4be5-9782-5dae6668beca"), 31, "Ampicilina" },
                    { new Guid("409bc791-f767-4050-ad9f-8df54c82e9bf"), 30, "Amoxicilina-clavulanato" },
                    { new Guid("ca4b56b6-09ec-42d4-86ee-46732101ccbe"), 29, "Amoxicilina" },
                    { new Guid("6f7d00cf-993a-4e60-9e90-aa8a6e1118bd"), 28, "Amitriptilina" },
                    { new Guid("ca24cb4e-4d92-484a-8172-ba9e50852037"), 27, "Amiodarona" },
                    { new Guid("3d415e40-03c9-4cfc-95c4-aa3497a0260d"), 26, "Aminofilina" },
                    { new Guid("7d074ff5-2e5c-4795-aed7-94fb80bed419"), 95, "Clopidogrel" },
                    { new Guid("5afb283c-2f45-4b76-ac16-f4ca041e3a02"), 96, "Cloranfenicol" },
                    { new Guid("9a663c83-725c-4b2e-8d9c-2774746f8f98"), 97, "Clordiazep�xido" },
                    { new Guid("7174018f-0f64-4a09-b1fa-1e054e5b16a3"), 98, "Cloroquina" },
                    { new Guid("f14a87b9-1e83-47c8-8cf0-b063c88f17b2"), 167, "Furosemida" },
                    { new Guid("41b9f271-0a2e-4026-9355-5fac79950b73"), 166, "Fosamprenavir" },
                    { new Guid("2fd43945-5c45-429c-b241-ec3b05a5df82"), 165, "Fluvastatina" },
                    { new Guid("5f0ad498-73ae-4b92-a16e-d785725f0b87"), 164, "Fluoxetina" },
                    { new Guid("c01a4d3b-5a75-4a38-b968-6e042cfcd266"), 163, "Flunitrazepam" },
                    { new Guid("c3a5987b-f853-456c-a7c7-5e20563d826f"), 162, "Flunarizina" },
                    { new Guid("4ddb6dc8-f7b2-44dc-b108-2b572485bc43"), 161, "Flumazenil" },
                    { new Guid("a158f76b-735a-4636-90c9-adb721111ced"), 160, "Fludrocortisona" },
                    { new Guid("badda5f7-f9ab-40f6-9e13-dae1e85621bf"), 159, "Fluconazol" },
                    { new Guid("3ff4237e-2fd2-462e-ae94-5cbc8f753fba"), 168, "Gabapentina" },
                    { new Guid("cd6ce162-a0cd-460c-92cb-1c0e27a97fe1"), 158, "Floratil" },
                    { new Guid("f339a856-0d34-4a01-b74a-88b9370e0187"), 156, "Finasterida" },
                    { new Guid("d672ac65-3cec-4b1f-b360-1fbded6d54a9"), 155, "Fentanil" },
                    { new Guid("0f2c4874-e8b5-4485-a7b0-8546382e7d22"), 154, "Fenotiazinas" },
                    { new Guid("c87f7bec-6f9a-4d65-9b37-8e98546eed22"), 153, "Fenobarbital" },
                    { new Guid("2b2be11c-51f2-4e31-8807-484c8a4e7ef6"), 152, "Fenito�na" },
                    { new Guid("42cf5273-5d02-49dd-b624-08be95ed743a"), 151, "Fenazopiridina" },
                    { new Guid("ec54a71d-97fc-4992-ae95-16cf3eb58664"), 150, "Etoricoxibe" },
                    { new Guid("0744b24e-12bc-4594-b68f-d079d6a6453f"), 149, "Etionamida" },
                    { new Guid("c538d149-a694-4d53-b2ff-fee24a40066c"), 148, "Etambutol" },
                    { new Guid("7af25be5-e754-49fe-b1ea-d11ad79f0934"), 157, "Fleet Enema" },
                    { new Guid("e258cad1-b025-434c-9ca6-234b22cc2826"), 169, "Ganciclovir" },
                    { new Guid("eb1fa136-0210-4e0e-ba6a-65f3b38a8d48"), 170, "Gatifloxacina" },
                    { new Guid("e2e914f4-047d-4c37-9a5b-da4437d12d3f"), 171, "Genfibrozil" },
                    { new Guid("ad5c5c60-9811-4037-9e92-1f8c12bf2e6a"), 192, "Hioscina Composta" },
                    { new Guid("ad9e95dc-867a-4ae0-8fda-5b06245b1d98"), 191, "Hioscina" },
                    { new Guid("18f7cda0-3165-40ff-a148-c97d5edfbae9"), 190, "Hidroxizina" },
                    { new Guid("22f1c00a-d26f-449f-ba95-dd04e78f085d"), 189, "Hidroxietilamido" },
                    { new Guid("aa17a05d-41d5-4ecf-b71c-dbcde74c2b57"), 188, "Hidr�xido de Alum�nio" },
                    { new Guid("2b53a2e3-7bf9-48d7-a4eb-eb4e0969f8c8"), 187, "Hidroxicloroquina" },
                    { new Guid("208f3795-1725-40a6-8b3c-93577288ab5c"), 186, "Hidrocortisona" },
                    { new Guid("e7af87d3-ad3d-45bf-aa31-290cbe3ce38f"), 185, "Hidroclorotiazida" },
                    { new Guid("bc955775-9235-498b-a8b3-2ce58ff2d079"), 184, "Hidralazina" },
                    { new Guid("9052f6e2-9c1c-43f9-9190-11ae1c27e7e6"), 183, "Heparina" },
                    { new Guid("43936858-360b-4505-b0ee-08c2687e2e37"), 182, "Haloperidol" },
                    { new Guid("5221531b-b916-4888-b954-933b3f5e040a"), 181, "Gluconato de C�lcio" },
                    { new Guid("f1485765-62cd-481d-8084-b46ef6959743"), 180, "Glucagon" },
                    { new Guid("53badb2b-699e-49f8-9200-988a5ca3c6c7"), 179, "Glipizida" },
                    { new Guid("757c28a6-8c00-4531-8a9a-ec369b8df073"), 178, "Glimepirida" },
                    { new Guid("68b51005-b9b0-43ed-ac6d-657b0af1f9fd"), 177, "Glicose" },
                    { new Guid("02608d96-e006-4d59-8e8c-e84bf90b41f9"), 176, "Gliclazida" },
                    { new Guid("97a0ef75-d70b-4a52-838d-255d571e69f6"), 175, "Glicerina" },
                    { new Guid("9ec55b33-30ff-4150-a290-319e1edbf1f1"), 174, "Glibenclamida" },
                    { new Guid("c729224d-dd0b-4756-9df9-1f67eb3841da"), 173, "Gingko Biloba" },
                    { new Guid("c896d206-202d-4356-9f2a-03cfbee824d0"), 172, "Gentamicina" },
                    { new Guid("866c07c8-b349-44d7-acf6-b8d32d9a86a5"), 147, "Estreptoquinase" },
                    { new Guid("3edacf48-56c1-40bc-aa34-58dee415439a"), 194, "Hipoglicemiantes orais" },
                    { new Guid("5b6fad1f-b240-4ce0-97bd-217856b7f32b"), 146, "Estreptomicina" },
                    { new Guid("40edcda0-5873-4069-a179-7a0ba833488d"), 144, "Espironolactona" },
                    { new Guid("af57966a-f3b1-4cfe-9750-a5483239ce4e"), 118, "Diclofenaco" },
                    { new Guid("33fa5916-1f38-442a-a3d1-f6631dcc6b08"), 117, "Diazepam" },
                    { new Guid("107712fe-2cb2-45a8-88ca-bf72e87cb40c"), 116, "Dexmedetomidine" },
                    { new Guid("d3fc0647-3dd7-4916-901a-88d6f32069b7"), 115, "Dexclorfeniramina" },
                    { new Guid("807a90ae-82e9-4927-96da-51828a8d8d6b"), 114, "Dexametasona" },
                    { new Guid("3d1dd6ae-0a28-477c-aa77-86fb241d96cd"), 113, "Desmopressina" },
                    { new Guid("6eb4bdc5-0cfd-4766-afba-3c114ead05d2"), 112, "Deslanos�deo C" },
                    { new Guid("abdaca1c-bf63-44ef-8cce-101072a03d88"), 111, "Delavirdina" },
                    { new Guid("d38f9c40-cd11-4bef-a458-c06fdd991edc"), 110, "Darunavir" },
                    { new Guid("ff53914c-926f-4673-9909-8b7243237ebf"), 119, "Didanosina" },
                    { new Guid("0013e265-2c37-418e-8942-1fc78e756a6e"), 109, "Daptomicina" },
                    { new Guid("e471a053-abf5-491e-8add-fba02f37dd36"), 107, "Dantrolene" },
                    { new Guid("5830210d-97c2-4e1f-bc4c-d74d169e924e"), 106, "Complexo B" },
                    { new Guid("40b96f17-196a-4c46-a9bb-fdd999f48f5a"), 105, "Colestiramina" },
                    { new Guid("02bebc3b-9072-480d-b50f-e12b6b2746a5"), 104, "Colchicina" },
                    { new Guid("ff0c5410-17d0-498b-922e-6ce63e777e80"), 103, "Codergocrina" },
                    { new Guid("1df63f24-f3d8-498a-8ecb-43506446aceb"), 102, "Code�na" },
                    { new Guid("32479bf9-0de1-450a-b07c-b667907ef9eb"), 101, "Clortalidona" },
                    { new Guid("f86dc2ec-96af-46fb-98ce-f65783d4f3ba"), 100, "Clorpropamida" },
                    { new Guid("523a5719-03ed-46a7-8e8d-2eff46c3ad38"), 99, "Clorpromazina" },
                    { new Guid("94206c76-b706-405f-b5bb-2b83a1fb74ab"), 108, "Dapsona" },
                    { new Guid("2b49187e-07ac-4175-bcb3-37d8bae1ec0f"), 120, "Dieta" },
                    { new Guid("ce9e596a-2a8a-4792-8622-fa43119f9403"), 121, "Digoxina" },
                    { new Guid("b042f78e-57c2-48bc-9d8b-ca2d92c0ae8e"), 122, "Diltiazem" },
                    { new Guid("9dfffd30-be29-424b-9a88-380e96c19a81"), 143, "Esmolol" },
                    { new Guid("8f15245a-61b6-4492-a254-1095b8865e08"), 142, "Ertapenem" },
                    { new Guid("eb6ce05a-2380-4fd5-9af4-332122beaa10"), 141, "Eritropoietina" },
                    { new Guid("73fe9206-7041-4c56-89b9-7131cbe573ee"), 140, "Eritromicina" },
                    { new Guid("c0c3c33b-e138-4d61-b9fe-a3ada018a56d"), 139, "Enoxiparina" },
                    { new Guid("afaa32c7-ca5d-4de7-9560-54114348cbe5"), 138, "Enalapril" },
                    { new Guid("9d8473a2-54e9-4bea-8858-ea2531785eac"), 137, "Efavirenz" },
                    { new Guid("45d48231-3e6b-4a79-abb6-8466907e455d"), 136, "Ebastina" },
                    { new Guid("f152be2c-99b8-427b-9ba9-b9ca14d4e56c"), 135, "Drotrecogina Alfa" },
                    { new Guid("f2530da3-4eae-4d9e-8f6b-a536693e4748"), 134, "Doxiciclina" },
                    { new Guid("05e523a9-44d6-4a95-9705-0586197b4d23"), 133, "Doxazosina" },
                    { new Guid("83dac4b5-ec41-48c9-81c3-dea35dc421bf"), 132, "Dopamina" },
                    { new Guid("ab17cfa4-30e4-44fb-a11f-ca4dd5794406"), 131, "Domperidona" },
                    { new Guid("d581a5c8-8f96-4d83-9b70-599e1bd8d19f"), 130, "Dobutamina" },
                    { new Guid("e1cf510e-c4f9-4cce-9728-93e8f94dbad6"), 129, "Diur�ticos de al�a" },
                    { new Guid("5406e298-0ff9-4177-9e8e-2cb3b48328c7"), 128, "Disopiramida" },
                    { new Guid("cb881579-5c03-4cfc-bfda-0863d8ca12ad"), 127, "Dipirona" },
                    { new Guid("0909edf7-e664-4cb6-b4d5-08f18ba1cace"), 126, "Diosmina-Hesperidina" },
                    { new Guid("14e4047e-6993-48ba-b7fd-c52bff2ece60"), 125, "Dinitrato de Isossorbida" },
                    { new Guid("f9e01268-d0f0-4403-bf1a-19bf3fd8e068"), 124, "Dimeticona" },
                    { new Guid("14e2cedd-46e7-40d8-b7ef-1aa854579250"), 123, "Dimenidrinato" },
                    { new Guid("d73f7c43-6005-4d67-9270-c3c92f97c89b"), 145, "Estavudina" },
                    { new Guid("88a388df-2102-4837-8106-d55b5d20b4c3"), 1, "Abacavir" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
