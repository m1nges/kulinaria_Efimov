--
-- PostgreSQL database dump
--

-- Dumped from database version 15.8
-- Dumped by pg_dump version 16.4

-- Started on 2025-04-02 13:30:13

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 229 (class 1255 OID 40996)
-- Name: add_osn(character varying); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.add_osn(IN "Dish_base_on" character varying)
    LANGUAGE sql
    AS $$ 
insert into public.osnova("Dish_base_on")
values ("Dish_base_on")
$$;


ALTER PROCEDURE public.add_osn(IN "Dish_base_on" character varying) OWNER TO postgres;

--
-- TOC entry 230 (class 1255 OID 40997)
-- Name: add_vid(character varying); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.add_vid(IN "vid bluda" character varying)
    LANGUAGE sql
    AS $$ 
INSERT INTO public.vidi_blud( "vid bluda")
	VALUES ("vid bluda");
$$;


ALTER PROCEDURE public.add_vid(IN "vid bluda" character varying) OWNER TO postgres;

--
-- TOC entry 231 (class 1255 OID 65575)
-- Name: insert_empty_datauser(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.insert_empty_datauser() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    INSERT INTO DataUser (user_id, email, passport_series, passport_number, kem_vidan_passport, vidan_date)
    VALUES (NEW.user_id, NULL, NULL, NULL, NULL, NULL);
    RETURN NEW;
END;
$$;


ALTER FUNCTION public.insert_empty_datauser() OWNER TO postgres;

--
-- TOC entry 232 (class 1255 OID 41084)
-- Name: new_dish(character varying, integer, integer, integer, character varying, character varying); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.new_dish(IN bludo_name character varying, IN dish_id integer, IN dish_base_on integer, IN dish_weight integer, IN add_osnova_name character varying, IN add_vid_bluda character varying)
    LANGUAGE sql
    AS $$
call add_osn(add_osnova_name);
call add_vid(add_vid_bluda);
insert into bluda(bludo_name, dish_id, dish_base_on, dish_weight)
values
(bludo_name, dish_id, dish_base_on, dish_weight)
$$;


ALTER PROCEDURE public.new_dish(IN bludo_name character varying, IN dish_id integer, IN dish_base_on integer, IN dish_weight integer, IN add_osnova_name character varying, IN add_vid_bluda character varying) OWNER TO postgres;

--
-- TOC entry 233 (class 1255 OID 65577)
-- Name: update_datauser(integer, character varying, character, character, character varying, date); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.update_datauser(IN p_user_id integer, IN p_email character varying, IN p_passport_series character, IN p_passport_number character, IN p_kem_vidan_passport character varying, IN p_vidan_date date)
    LANGUAGE plpgsql
    AS $$
BEGIN
    UPDATE DataUser
    SET
        email = p_email,
        passport_series = p_passport_series,
        passport_number = p_passport_number,
        kem_vidan_passport = p_kem_vidan_passport,
        vidan_date = p_vidan_date
    WHERE user_id = p_user_id;

    IF NOT FOUND THEN
        INSERT INTO DataUser (user_id, email, passport_series, passport_number, kem_vidan_passport, vidan_date)
        VALUES (p_user_id, p_email, p_passport_series, p_passport_number, p_kem_vidan_passport, p_vidan_date);
    END IF;
END;
$$;


ALTER PROCEDURE public.update_datauser(IN p_user_id integer, IN p_email character varying, IN p_passport_series character, IN p_passport_number character, IN p_kem_vidan_passport character varying, IN p_vidan_date date) OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 214 (class 1259 OID 40998)
-- Name: bluda; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.bluda (
    id_bluda integer NOT NULL,
    bludo_name character varying(100),
    dish_id integer,
    dish_base_on integer,
    dish_weight integer,
    bludo_image character varying
);


ALTER TABLE public.bluda OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 41003)
-- Name: bluda_id_bluda_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.bluda_id_bluda_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.bluda_id_bluda_seq OWNER TO postgres;

--
-- TOC entry 3402 (class 0 OID 0)
-- Dependencies: 215
-- Name: bluda_id_bluda_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.bluda_id_bluda_seq OWNED BY public.bluda.id_bluda;


--
-- TOC entry 228 (class 1259 OID 65567)
-- Name: datauser; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.datauser (
    user_id integer,
    email character varying(256),
    passport_series character(4),
    passport_number character(6),
    kem_vidan_passport character varying(200),
    vidan_date date
);


ALTER TABLE public.datauser OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 41004)
-- Name: osnova; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.osnova (
    "Id_osnovi" integer NOT NULL,
    "Dish_base_on" character varying(50)
);


ALTER TABLE public.osnova OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 41007)
-- Name: osnova_Id_osnovi_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."osnova_Id_osnovi_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public."osnova_Id_osnovi_seq" OWNER TO postgres;

--
-- TOC entry 3403 (class 0 OID 0)
-- Dependencies: 217
-- Name: osnova_Id_osnovi_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."osnova_Id_osnovi_seq" OWNED BY public.osnova."Id_osnovi";


--
-- TOC entry 218 (class 1259 OID 41008)
-- Name: products; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.products (
    "Product_id" integer NOT NULL,
    "Product_name" character varying(70),
    "Protein" integer,
    "Fat" integer,
    "Carbs" integer
);


ALTER TABLE public.products OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 41011)
-- Name: products_Product_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."products_Product_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public."products_Product_id_seq" OWNER TO postgres;

--
-- TOC entry 3404 (class 0 OID 0)
-- Dependencies: 219
-- Name: products_Product_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."products_Product_id_seq" OWNED BY public.products."Product_id";


--
-- TOC entry 220 (class 1259 OID 41012)
-- Name: recipes; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.recipes (
    id_bluda integer,
    recipe character varying(500)
);


ALTER TABLE public.recipes OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 41015)
-- Name: roles; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.roles (
    role_id integer NOT NULL,
    role_name character varying(52)
);


ALTER TABLE public.roles OWNER TO postgres;

--
-- TOC entry 222 (class 1259 OID 41018)
-- Name: roles_role_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.roles ALTER COLUMN role_id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.roles_role_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 223 (class 1259 OID 41019)
-- Name: sostav_blud; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.sostav_blud (
    dish_id integer,
    product_id integer,
    weight integer
);


ALTER TABLE public.sostav_blud OWNER TO postgres;

--
-- TOC entry 224 (class 1259 OID 41022)
-- Name: users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.users (
    user_id integer NOT NULL,
    first_name character varying(20) NOT NULL,
    last_name character varying(20) NOT NULL,
    patronymic character varying(20),
    date_of_birth date,
    login character varying(2) NOT NULL,
    password text NOT NULL,
    phone character varying(20),
    adress character varying(20),
    role_id integer DEFAULT 3
);


ALTER TABLE public.users OWNER TO postgres;

--
-- TOC entry 225 (class 1259 OID 41028)
-- Name: users_user_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.users ALTER COLUMN user_id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.users_user_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 226 (class 1259 OID 41029)
-- Name: vidi_blud; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.vidi_blud (
    "Nomer vida bluda" integer NOT NULL,
    "vid bluda" character varying(50)
);


ALTER TABLE public.vidi_blud OWNER TO postgres;

--
-- TOC entry 227 (class 1259 OID 41032)
-- Name: vidi_blud_Nomer vida bluda_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."vidi_blud_Nomer vida bluda_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public."vidi_blud_Nomer vida bluda_seq" OWNER TO postgres;

--
-- TOC entry 3405 (class 0 OID 0)
-- Dependencies: 227
-- Name: vidi_blud_Nomer vida bluda_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."vidi_blud_Nomer vida bluda_seq" OWNED BY public.vidi_blud."Nomer vida bluda";


--
-- TOC entry 3215 (class 2604 OID 41033)
-- Name: bluda id_bluda; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bluda ALTER COLUMN id_bluda SET DEFAULT nextval('public.bluda_id_bluda_seq'::regclass);


--
-- TOC entry 3216 (class 2604 OID 41034)
-- Name: osnova Id_osnovi; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.osnova ALTER COLUMN "Id_osnovi" SET DEFAULT nextval('public."osnova_Id_osnovi_seq"'::regclass);


--
-- TOC entry 3217 (class 2604 OID 41035)
-- Name: products Product_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products ALTER COLUMN "Product_id" SET DEFAULT nextval('public."products_Product_id_seq"'::regclass);


--
-- TOC entry 3219 (class 2604 OID 41036)
-- Name: vidi_blud Nomer vida bluda; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vidi_blud ALTER COLUMN "Nomer vida bluda" SET DEFAULT nextval('public."vidi_blud_Nomer vida bluda_seq"'::regclass);


--
-- TOC entry 3382 (class 0 OID 40998)
-- Dependencies: 214
-- Data for Name: bluda; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.bluda (id_bluda, bludo_name, dish_id, dish_base_on, dish_weight, bludo_image) FROM stdin;
2	Salat myaSnoy	1	2	200	\N
3	Salat vitaminniy	1	1	200	\N
4	Salat ribniy	1	3	200	\N
5	Pashtet iz ribi	1	3	120	\N
6	Myaso S garnirom	3	2	250	\N
7	Smetana	1	4	140	\N
10	Sup-pure iz ribi	2	3	500	\N
11	Uha iz Sudaka	2	3	500	\N
12	Sup molochniy	2	4	500	\N
14	BeefStroganov	3	2	210	\N
15	Sudak po-polSki	3	3	160	\N
16	Drachena	3	5	180	\N
17	Morkov S riSom	3	1	260	\N
18	Sirniki	3	4	220	\N
20	Kasha riSovaya	3	6	210	\N
21	Puding riSoviy	3	6	160	\N
22	Vareniki lenivie	3	4	220	\N
23	Pomidori S lukom	3	1	260	\N
24	Sufle iz tvoroga	3	4	280	\N
26	YAbloki pechenie	4	7	160	\N
27	Sufle yablochnoe	4	7	220	\N
28	Krem tvorozhniy	4	4	160	\N
29	"Utro"	5	7	200	\N
30	Kompot	5	7	200	\N
31	Molochniy napitok	5	4	200	\N
32	Kofe cherniy	5	8	200	\N
33	Kofe na moloke	5	8	200	\N
37	подопытное	3	2	300	\N
42	new dish haha	3	5	300	\N
1	Salat letniy	1	1	200	../../Images\\салат летний.jpg
8	Tvorog	1	4	140	../../Images\\творог.jpg
9	Sup harcho	2	2	500	../../Images\\харчо.jpg
13	BaSturma	3	2	300	../../Images\\бастурма.jpg
19	Omlet S lukom	3	5	200	../../Images\\омлет с луком.jpg
25	Rulet S yablokami	4	7	200	../../Images\\рулет с яблоками.jpg
39	htrhrt	1	1	300	../../images/picture.jpg
\.


--
-- TOC entry 3396 (class 0 OID 65567)
-- Dependencies: 228
-- Data for Name: datauser; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.datauser (user_id, email, passport_series, passport_number, kem_vidan_passport, vidan_date) FROM stdin;
1	example@mail.com	1234	567890	Отделом УФМС по г. Москва	2020-01-01
3	example@mail.com	1234	567890	Отделом УФМС по г. Москва	2020-01-01
4	example@mail.com	1234	567890	Отделом УФМС по г. Москва	2020-01-01
5	example@mail.com	1234	567890	Отделом УФМС по г. Москва	2020-01-01
15	example@mail.com	1234	567890	Отделом УФМС по г. Москва	2020-01-01
2	Gk@gmail.com	4441	123456	Отделом УФМС по г. Москва	2020-01-01
16	\N	\N	\N	\N	\N
21	\N	\N	\N	\N	\N
22	\N	\N	\N	\N	\N
24	efimovegor558@gmail.com	\N	\N	\N	\N
\.


--
-- TOC entry 3384 (class 0 OID 41004)
-- Dependencies: 216
-- Data for Name: osnova; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.osnova ("Id_osnovi", "Dish_base_on") FROM stdin;
1	овощи
2	мясо
3	рыба
4	молоко
5	яйца
6	крупа
7	фрукты
8	кофе
9	кровь
10	зелень
11	пюре
12	Новая основа
\.


--
-- TOC entry 3386 (class 0 OID 41008)
-- Dependencies: 218
-- Data for Name: products; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.products ("Product_id", "Product_name", "Protein", "Fat", "Carbs") FROM stdin;
24	new	5	5	5
1	Govyadina	189	62	0
2	Sudak	190	40	0
3	Maslo	60	413	90
4	Mayonez	31	335	26
5	Yaica	127	58	7
6	Smetana	26	150	28
7	Moloko	28	16	47
8	Tvorog	167	45	13
9	Morkov	13	1	70
10	Luk	17	0	95
11	Pomidori	6	0	42
12	Zelen	9	0	20
13	Ris	70	3	773
14	Myka	106	7	732
15	Yabloki	4	0	113
16	Saxap	0	0	998
17	Kofe	127	18	9
18	Курица	17	2	0
\.


--
-- TOC entry 3388 (class 0 OID 41012)
-- Dependencies: 220
-- Data for Name: recipes; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.recipes (id_bluda, recipe) FROM stdin;
6	Мясо варе...
7	Сметану п...
8	Протертый ..
9	Грудинку ...
10	Филе суда...
10	Филе суда...
11	Судак очи...
12	Промытый ...
13	Мясо наре...
14	Говядину ...
15	Подготовл...
16	Сырые яйц...
17	Нарезать ...
19	К свежим ...
20	Рис свари...
21	Готовую р...
23	Спассеров...
24	В протерт...
24	В протерт...
24	В протерт...
25	Очистить ...
26	Не прорез...
27	Запеченны...
28	Яйца разм...
29	Очищенную ..
30	Яблоки оч...
31	Яблоки на...
32	Кофеварку ..
33	Сварить ч...
5	Крутой рецепт для паштета из рыбы
18	Крутой рецепт для симики
3	есть рецепт
22	пкупук
37	hrtg
1	Чето там помидоры
2	Мясо ляляля
\.


--
-- TOC entry 3389 (class 0 OID 41015)
-- Dependencies: 221
-- Data for Name: roles; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.roles (role_id, role_name) FROM stdin;
1	Администратор
2	Менеджер
3	Шеф-Повар
\.


--
-- TOC entry 3391 (class 0 OID 41019)
-- Dependencies: 223
-- Data for Name: sostav_blud; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.sostav_blud (dish_id, product_id, weight) FROM stdin;
1	11	100
9	11	25
16	7	35
24	8	80
1	15	80
9	13	35
16	6	15
24	7	100
1	12	5
9	12	15
16	14	9
24	5	40
1	4	15
9	3	15
16	3	5
24	6	30
2	1	65
10	2	70
17	9	150
24	16	20
2	9	40
10	7	250
17	7	50
24	3	10
2	11	35
10	3	20
17	13	25
24	14	10
2	12	20
10	14	15
17	3	20
25	15	120
2	5	20
10	12	5
17	12	10
25	16	35
2	4	20
11	2	100
17	14	5
25	14	30
3	11	55
11	9	20
18	8	140
25	8	20
3	15	55
11	10	20
18	6	30
25	3	20
3	6	50
11	3	5
18	14	15
26	15	150
3	12	20
11	12	2
18	5	10
26	16	20
3	10	15
12	7	350
18	16	15
26	3	2
3	16	5
12	13	35
19	5	120
27	15	50
4	2	50
12	3	5
19	7	45
27	7	150
4	11	50
12	16	5
19	10	20
27	5	80
4	4	40
13	1	180
19	3	15
27	16	35
4	9	35
13	11	100
20	13	50
27	3	2
4	5	20
13	10	40
20	7	75
28	8	100
4	12	5
13	12	20
20	15	75
28	5	20
5	2	80
13	3	5
20	16	10
28	6	20
5	9	40
14	1	90
20	3	5
28	16	15
5	3	25
14	7	50
21	13	70
28	3	10
5	12	5
14	6	20
21	6	30
29	15	150
6	1	80
14	10	10
21	3	20
29	9	200
6	11	150
14	3	5
21	5	20
29	16	15
6	4	30
14	12	5
21	16	15
30	15	70
6	12	10
14	14	3
22	8	140
30	16	10
7	6	125
15	2	100
22	6	30
31	7	150
7	16	15
15	9	20
22	14	20
31	15	150
8	8	75
15	5	20
22	16	15
31	16	25
8	6	50
15	3	20
22	5	8
32	17	8
8	16	15
15	10	10
23	11	250
33	17	8
9	1	80
15	12	5
23	10	65
33	16	25
9	10	30
16	5	120
23	3	20
33	7	75
37	7	300
39	24	59
\.


--
-- TOC entry 3392 (class 0 OID 41022)
-- Dependencies: 224
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.users (user_id, first_name, last_name, patronymic, date_of_birth, login, password, phone, adress, role_id) FROM stdin;
3	Андрей	Иванов	Сидорович	2001-03-20	AI	e09cc2272237ec8c6e7bfdafc39b2b4e88d7e33e44a4c7ffacfea6ade0c961258896c08f118c1b891170affc77406f19fc5ccc7e326a80aa54187f97fa4cc3a8	9111234565	СПб	2
1	Василий	Пилюлькин	Петрович	1997-01-12	vp	ca4b17f1df7b9f1762adb155826a25a6115ca9dd08f770d028efeb3f07e399dce9fb56acaec7b9fc0bb495a8c26c5bb00edb8b6e8db45c51d21f69c782842a9c	9616105285	Металлистов 117	1
5	Egor	Efimov	Eugenyevich	2024-12-07	EE	8dbe0e4050b44bf5f2ec3a1831b8404bd08d5541c82a8f69173b52f19981ca4abf619b2ff9292248afc5841cf3e7a578a8c3005aa1d103a6ac39fb0637d7652c			1
4	Клавдий	Плющкин	Андреевич	2000-05-25	KP	feb13f2bbea8580b6c840b1868b987411852cb9b203afcd787a807bf4f06a7a518c91f30a3579c99b2af384e1d1a627b2267cb558357a0da17523b1370c8eb26	9817854261	СПб	2
2	Геннадий	Крокодилов	Иванович	1999-02-15	GK	fa8d3dcafc067b5f46b3f175315a104ebb4c3e2ab14d90474cc41bf2ec94382789a3d82dc7be3addb094b7a2749bc37a67d7d8e9f927582af6b6f42a65e9281c	9112365489	СПб	1
16	Алина	Титова	\N	\N	AT	0f526690a183066a1104d5401cda794ab5f1ea09902f612e431ac0de3e77fc0d67d094b93421a3bf24ed152923eae325b46e4e355152bba66c689e0b40e82daa	\N	\N	3
21	Петр	Петров	\N	\N	PP	cc9687bbb04b3898f5d8a4f8dc4a39bba474e3e68430bcd25c31fd07865b2f8a220e09db6df362392443f155693732a5ed34c91752e703748743f09ed6898b95	\N	\N	3
22	Сидоров	Иван	\N	\N	SI	c6a5cc1a0576db5fb956c66486be0839659a9eda52f49ac8adf263871c47e96c4e5b30e3cdd7b956835d7778d4295008c3fabf1d1cd3f9cb77033a99b2aa99e0	\N	\N	3
24	пук	пку	\N	\N	GJ	9c16217ec2410f37cdded90ee13d0c1b06e4087ee16a6c23f2d48cd412c24dc45a45f825a0ffb66e28c51c46370b5044dd99edab7b4c4902b6d148ed7a99130c	\N	\N	3
15	Иван	Иванов	Иванович	1990-01-01	ii	8dbe0e4050b44bf5f2ec3a1831b8404bd08d5541c82a8f69173b52f19981ca4abf619b2ff9292248afc5841cf3e7a578a8c3005aa1d103a6ac39fb0637d7652c	+79991234567	Москва	3
\.


--
-- TOC entry 3394 (class 0 OID 41029)
-- Dependencies: 226
-- Data for Name: vidi_blud; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.vidi_blud ("Nomer vida bluda", "vid bluda") FROM stdin;
1	Закуска
2	Суп
3	Горячее
4	Десерт
5	Напиток
6	рыбка
7	от мамы
8	vkusni
9	картошка
10	Новый вид блюда
\.


--
-- TOC entry 3406 (class 0 OID 0)
-- Dependencies: 215
-- Name: bluda_id_bluda_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.bluda_id_bluda_seq', 42, true);


--
-- TOC entry 3407 (class 0 OID 0)
-- Dependencies: 217
-- Name: osnova_Id_osnovi_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."osnova_Id_osnovi_seq"', 12, true);


--
-- TOC entry 3408 (class 0 OID 0)
-- Dependencies: 219
-- Name: products_Product_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."products_Product_id_seq"', 24, true);


--
-- TOC entry 3409 (class 0 OID 0)
-- Dependencies: 222
-- Name: roles_role_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.roles_role_id_seq', 3, true);


--
-- TOC entry 3410 (class 0 OID 0)
-- Dependencies: 225
-- Name: users_user_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.users_user_id_seq', 24, true);


--
-- TOC entry 3411 (class 0 OID 0)
-- Dependencies: 227
-- Name: vidi_blud_Nomer vida bluda_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."vidi_blud_Nomer vida bluda_seq"', 10, true);


--
-- TOC entry 3221 (class 2606 OID 41038)
-- Name: bluda bluda_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bluda
    ADD CONSTRAINT bluda_pkey PRIMARY KEY (id_bluda);


--
-- TOC entry 3223 (class 2606 OID 41040)
-- Name: osnova osnova_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.osnova
    ADD CONSTRAINT osnova_pkey PRIMARY KEY ("Id_osnovi");


--
-- TOC entry 3225 (class 2606 OID 41042)
-- Name: products products_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_pkey PRIMARY KEY ("Product_id");


--
-- TOC entry 3227 (class 2606 OID 41044)
-- Name: roles roles_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.roles
    ADD CONSTRAINT roles_pkey PRIMARY KEY (role_id);


--
-- TOC entry 3229 (class 2606 OID 41046)
-- Name: users users_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (user_id);


--
-- TOC entry 3231 (class 2606 OID 41048)
-- Name: vidi_blud vidi_blud_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vidi_blud
    ADD CONSTRAINT vidi_blud_pkey PRIMARY KEY ("Nomer vida bluda");


--
-- TOC entry 3239 (class 2620 OID 65576)
-- Name: users after_user_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER after_user_insert AFTER INSERT ON public.users FOR EACH ROW EXECUTE FUNCTION public.insert_empty_datauser();


--
-- TOC entry 3232 (class 2606 OID 41049)
-- Name: bluda bluda_dish_base_on_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bluda
    ADD CONSTRAINT bluda_dish_base_on_fkey FOREIGN KEY (dish_base_on) REFERENCES public.osnova("Id_osnovi");


--
-- TOC entry 3233 (class 2606 OID 41054)
-- Name: bluda bluda_dish_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bluda
    ADD CONSTRAINT bluda_dish_id_fkey FOREIGN KEY (dish_id) REFERENCES public.vidi_blud("Nomer vida bluda");


--
-- TOC entry 3238 (class 2606 OID 65570)
-- Name: datauser datauser_user_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.datauser
    ADD CONSTRAINT datauser_user_id_fkey FOREIGN KEY (user_id) REFERENCES public.users(user_id);


--
-- TOC entry 3234 (class 2606 OID 41059)
-- Name: recipes recipes_id_bluda_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.recipes
    ADD CONSTRAINT recipes_id_bluda_fkey FOREIGN KEY (id_bluda) REFERENCES public.bluda(id_bluda);


--
-- TOC entry 3235 (class 2606 OID 41079)
-- Name: sostav_blud sostav_blud_dish_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sostav_blud
    ADD CONSTRAINT sostav_blud_dish_id_fkey FOREIGN KEY (dish_id) REFERENCES public.bluda(id_bluda) ON DELETE CASCADE;


--
-- TOC entry 3236 (class 2606 OID 41069)
-- Name: sostav_blud sostav_blud_product_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sostav_blud
    ADD CONSTRAINT sostav_blud_product_id_fkey FOREIGN KEY (product_id) REFERENCES public.products("Product_id");


--
-- TOC entry 3237 (class 2606 OID 41074)
-- Name: users users_role_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_role_id_fkey FOREIGN KEY (role_id) REFERENCES public.roles(role_id);


-- Completed on 2025-04-02 13:30:13

--
-- PostgreSQL database dump complete
--

