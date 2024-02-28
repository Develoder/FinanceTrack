PGDMP                      |            finance_track    16.2    16.2                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16406    finance_track    DATABASE     �   CREATE DATABASE finance_track WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE finance_track;
                postgres    false            �            1259    16414    account    TABLE     �   CREATE TABLE public.account (
    id integer NOT NULL,
    name character(20) NOT NULL,
    type_id integer NOT NULL,
    balance money NOT NULL,
    user_id integer NOT NULL
);
    DROP TABLE public.account;
       public         heap    postgres    false            �            1259    16413    account_id_seq    SEQUENCE     �   ALTER TABLE public.account ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.account_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    218            �            1259    16452    category_transaction    TABLE     �   CREATE TABLE public.category_transaction (
    id integer NOT NULL,
    name character(20) NOT NULL,
    "order" integer NOT NULL,
    type boolean NOT NULL
);
 (   DROP TABLE public.category_transaction;
       public         heap    postgres    false                       0    0     COLUMN category_transaction.type    COMMENT     a   COMMENT ON COLUMN public.category_transaction.type IS 'true - доход, false - расход';
          public          postgres    false    224            �            1259    16436    transaction    TABLE       CREATE TABLE public.transaction (
    id integer NOT NULL,
    amount money NOT NULL,
    date timestamp without time zone NOT NULL,
    category_id integer NOT NULL,
    description character(100) NOT NULL,
    account_id integer NOT NULL,
    user_id integer NOT NULL
);
    DROP TABLE public.transaction;
       public         heap    postgres    false            �            1259    16435    transaction_id_seq    SEQUENCE     �   ALTER TABLE public.transaction ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.transaction_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    222            �            1259    16425    type_account    TABLE     }   CREATE TABLE public.type_account (
    id integer NOT NULL,
    name character(20) NOT NULL,
    "order" integer NOT NULL
);
     DROP TABLE public.type_account;
       public         heap    postgres    false            �            1259    16424    type_account_id_seq    SEQUENCE     �   ALTER TABLE public.type_account ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.type_account_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    220            �            1259    16451    type_transaction_id_seq    SEQUENCE     �   ALTER TABLE public.category_transaction ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.type_transaction_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    224            �            1259    16408    user    TABLE     ~   CREATE TABLE public."user" (
    id integer NOT NULL,
    name character(20) NOT NULL,
    password character(40) NOT NULL
);
    DROP TABLE public."user";
       public         heap    postgres    false            �            1259    16407    user_id_seq    SEQUENCE     �   ALTER TABLE public."user" ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.user_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    216            g           2606    16418    account account_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.account
    ADD CONSTRAINT account_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.account DROP CONSTRAINT account_pkey;
       public            postgres    false    218            k           2606    16440    transaction transaction_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.transaction
    ADD CONSTRAINT transaction_pkey PRIMARY KEY (id);
 F   ALTER TABLE ONLY public.transaction DROP CONSTRAINT transaction_pkey;
       public            postgres    false    222            i           2606    16429    type_account type_account_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.type_account
    ADD CONSTRAINT type_account_pkey PRIMARY KEY (id);
 H   ALTER TABLE ONLY public.type_account DROP CONSTRAINT type_account_pkey;
       public            postgres    false    220            m           2606    16456 *   category_transaction type_transaction_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public.category_transaction
    ADD CONSTRAINT type_transaction_pkey PRIMARY KEY (id);
 T   ALTER TABLE ONLY public.category_transaction DROP CONSTRAINT type_transaction_pkey;
       public            postgres    false    224            e           2606    16412    user user_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public."user"
    ADD CONSTRAINT user_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public."user" DROP CONSTRAINT user_pkey;
       public            postgres    false    216            n           2606    16430    account account_type_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.account
    ADD CONSTRAINT account_type_id_fkey FOREIGN KEY (type_id) REFERENCES public.type_account(id) NOT VALID;
 F   ALTER TABLE ONLY public.account DROP CONSTRAINT account_type_id_fkey;
       public          postgres    false    218    220    4713            o           2606    16419    account account_user_id_fkey    FK CONSTRAINT     |   ALTER TABLE ONLY public.account
    ADD CONSTRAINT account_user_id_fkey FOREIGN KEY (user_id) REFERENCES public."user"(id);
 F   ALTER TABLE ONLY public.account DROP CONSTRAINT account_user_id_fkey;
       public          postgres    false    216    4709    218            p           2606    16441 '   transaction transaction_account_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.transaction
    ADD CONSTRAINT transaction_account_id_fkey FOREIGN KEY (account_id) REFERENCES public.account(id);
 Q   ALTER TABLE ONLY public.transaction DROP CONSTRAINT transaction_account_id_fkey;
       public          postgres    false    218    222    4711            q           2606    16457 (   transaction transaction_category_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.transaction
    ADD CONSTRAINT transaction_category_id_fkey FOREIGN KEY (category_id) REFERENCES public.category_transaction(id) NOT VALID;
 R   ALTER TABLE ONLY public.transaction DROP CONSTRAINT transaction_category_id_fkey;
       public          postgres    false    4717    224    222            r           2606    16446 $   transaction transaction_user_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.transaction
    ADD CONSTRAINT transaction_user_id_fkey FOREIGN KEY (user_id) REFERENCES public."user"(id);
 N   ALTER TABLE ONLY public.transaction DROP CONSTRAINT transaction_user_id_fkey;
       public          postgres    false    222    4709    216           