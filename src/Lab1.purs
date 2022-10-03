module Lab1 where

import Prelude
import Effect(Effect)
import Effect.Console (log)
import Data.List (List(..))

singleton :: forall a. a -> List a
singleton a = (Cons a Nil)

null :: forall a. List a -> Boolean
null Nil = true
null _ = false

snoc:: forall a. List a -> a -> List a
snoc Nil x = Cons x Nil
snoc (Cons y ys) x = Cons y (snoc ys x)

length :: forall a. List a -> Int
length Nil = 0
length (Cons _ xs) = 1 + length xs